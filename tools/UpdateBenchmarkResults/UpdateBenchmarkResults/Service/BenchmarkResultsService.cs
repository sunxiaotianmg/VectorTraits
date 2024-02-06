﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using UpdateBenchmarkResults.Common;
using UpdateBenchmarkResults.Model;

namespace UpdateBenchmarkResults.Service {
    /// <summary>
    /// Benchmark results service
    /// </summary>
    internal class BenchmarkResultsService {

        /// <inheritdoc cref="BenchmarkStringUtil.comparisonType"/>
        const StringComparison comparisonType = BenchmarkStringUtil.comparisonType;

        /// <summary>Default Encoding.</summary>
        static readonly Encoding encoding = Encoding.UTF8;

        /// <summary>
        /// Text writer.
        /// </summary>
        public TextWriter? Writer { get; set; }

        /// <summary>
        /// Source file (源文件).
        /// </summary>
        public string SourceFile { get; set; } = string.Empty;

        /// <summary>
        /// Destination folder (目标文件夹).
        /// </summary>
        public string Folder { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public List<InputFramework> List { get; } = new List<InputFramework>();

        /// <summary>
        /// Group counter (组的计数器).
        /// </summary>
        public IDictionary<string, int> GroupCounter { get; set; } = new SortedDictionary<string, int>();

        /// <summary>
        /// Source base name (源基本名).
        /// </summary>
        public string SourceBaseName { get; set; } = string.Empty;

        /// <summary>
        /// Cpu model name (CPU型号名).
        /// </summary>
        public string CpuModelName { get; set; } = string.Empty;

        /// <summary>
        /// Architecture string (架构字符串).
        /// </summary>
        public string ArchitectureString { get; set; } = string.Empty;

        /// <summary>
        /// Architecture family (架构系列). 如 X86/Arm.
        /// </summary>
        public string ArchitectureFamily { get; set; } = string.Empty;

        /// <summary>
        /// Architecture sort code (架构排序代码).
        /// </summary>
        public string ArchitectureSortCode { get; set; } = string.Empty;

        /// <summary>
        /// Parse command line args.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public void ParseCommand(string[] args) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            if (null == args) return;
            //int idx = 0;
            foreach (string arg in args) {
                if (string.IsNullOrEmpty(arg)) continue;
                if (arg.StartsWith('-')) {
                    ReadOnlySpan<char> dst = VectorTextUtil.SplitKeyValue(arg, out string key);
                    if ("-folder".Equals(key, comparisonType)) {
                        Folder = dst.ToString();
                    }
                    //if ("-allowFakeBenchmark0".Equals(key, comparisonType)) {
                    //    AllowFakeBenchmark = false;
                    //}
                } else {
                    if (string.IsNullOrEmpty(SourceFile)) {
                        SourceFile = arg;
                    }
                }
            }
        }

        /// <summary>
        /// Run with command line args.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public void RunWithCommand(string[] args) {
            Clear();
            ParseCommand(args);
            Run();
        }

        /// <summary>
        /// Clear.
        /// </summary>
        private void Clear() {
            List.Clear();
            GroupCounter.Clear();
            SourceBaseName = string.Empty;
            CpuModelName = string.Empty;
            ArchitectureString = string.Empty;
            ArchitectureFamily = string.Empty;
            ArchitectureSortCode = string.Empty;
        }

        /// <summary>
        /// Run.
        /// </summary>
        public void Run() {
            if (null == Writer) return;
            Writer.WriteLine("SourceFile:\t{0}", SourceFile);
            if (string.IsNullOrEmpty(SourceFile)) {
                Writer.WriteLine("[Error] SourceFile is empty!");
                return;
            }
            Load();
            // Process.
            Process();
            // Finish.
            Writer.WriteLine("Finish.");
        }

        internal enum LoadPhase {
            /// <summary>Init. 即“####”之前的非代码区域.</summary>
            Init,
            /// <summary>Other code. 即“####”之前的代码区域.</summary>
            OtherCode,
            /// <summary>Framework. 已经遇到了“####”，非代码区域.</summary>
            Framework,
            /// <summary>Framework code. 已经遇到了“####”，尚未遇到case.</summary>
            FrameworkCode,
            /// <summary>Framework Case. 已经遇到了 case, 这表示 header区域结束 .</summary>
            FrameworkCase
        }

        /// <summary>
        /// Load.
        /// </summary>
        private void Load() {
            LoadParse();
            LoadDone();
        }

        /// <summary>
        /// Load parse. parse file.
        /// </summary>
        private void LoadParse() {
            string FrameworkPrefix = "####";
            string CodeDelimiter = "```";
            InputFramework? inputFramework = null;
            InputCase? inputCase = null;
            LoadPhase phase = LoadPhase.Init;
            string title;
            int lineNo = 1;
            SourceBaseName = Path.GetFileNameWithoutExtension(SourceFile);
            foreach (string line in File.ReadLines(SourceFile)) {
                if (lineNo <= 30) {
                    //Writer.WriteLine("{0}\t{1}", lineNo, line);
                }
                if (null != line) {
                    bool needNewFramework = false;
                    bool needAppend = false;
                    switch(phase) {
                        case LoadPhase.Init:
                            if (line.StartsWith(FrameworkPrefix)) {
                                phase = LoadPhase.Framework;
                                needNewFramework = true;
                            } else if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.OtherCode;
                            } else {
                                // Ignore.
                            }
                            break;
                        case LoadPhase.OtherCode:
                            if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.Init;
                            } else {
                                // Ignore.
                            }
                            break;
                        case LoadPhase.Framework:
                            if (line.StartsWith(FrameworkPrefix)) {
                                phase = LoadPhase.Framework;
                                needNewFramework = true;
                            } else if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.FrameworkCode;
                            } else {
                                // Ignore.
                            }
                            break;
                        default: // FrameworkCode or others.
                            if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.Framework;
                            } else {
                                if (line.Length > 0) {
                                    title = BenchmarkStringUtil.ExtractCaseTitle(line);
                                    if (!string.IsNullOrEmpty(title)) {
                                        phase = LoadPhase.FrameworkCase;
                                        SubmitCase();
                                        inputCase = new InputCase();
                                        inputCase.Title = title;
                                        string baseTitle = BenchmarkStringUtil.GetCaseBaseTitle(title);
                                        inputCase.BaseTitle = baseTitle;
                                        string primaryTitle = BenchmarkStringUtil.GetCasePrimaryTitle(title);
                                        inputCase.PrimaryTitle = primaryTitle;
                                        if (null!= inputFramework) {
                                            int num;
                                            if (!inputFramework.GroupCounter.TryGetValue(primaryTitle, out num)) {
                                                num = 0;
                                            }
                                            inputFramework.GroupCounter[primaryTitle] = num + 1;
                                            // Group.
                                            if (!GroupCounter.TryGetValue(primaryTitle, out num)) {
                                                num = 0;
                                            }
                                            GroupCounter[primaryTitle] = num + 1;
                                        }
                                    }
                                    if (phase != LoadPhase.FrameworkCode) {
                                        needAppend = true;
                                    }
                                } else {
                                    if (null!= inputCase) {
                                        SubmitCase();
                                    }
                                }
                                if (phase == LoadPhase.FrameworkCode) {
                                    if (string.IsNullOrEmpty(ArchitectureString)) {
                                        ArchitectureString = BenchmarkStringUtil.GetValueByPrefix(BenchmarkStringUtil.OSArchitecturePrefix, line);
                                        if (!string.IsNullOrEmpty(ArchitectureString)) {
                                            ArchitectureFamily = BenchmarkStringUtil.GetArchitectureFamily(ArchitectureString);
                                            ArchitectureSortCode = BenchmarkStringUtil.GetArchitectureSortCode(ArchitectureFamily);
                                        }
                                    }
                                    if (string.IsNullOrEmpty(CpuModelName)) {
                                        CpuModelName = BenchmarkStringUtil.GetValueByPrefix(BenchmarkStringUtil.CpuModelNamePrefix, line);
                                    }
                                    inputFramework?.Header.Add(line);
                                }
                            }
                            break;
                    }
                    if (needNewFramework) {
                        // Submit old.
                        if (null != inputFramework) {
                            SubmitFramework();
                        }
                        // Make new Framework
                        title = line.Substring(FrameworkPrefix.Length + 1).Trim();
                        inputFramework = new InputFramework();
                        inputFramework.Title = title;
                    }
                    // needAppend.
                    if (needAppend && null != inputCase) {
                        inputCase.Lines.Add(line);
                    }
                }
                // next.
                ++lineNo;
            }
            if (null != inputFramework) {
                List.Add(inputFramework);
                //inputFramework = null;
            }

            void SubmitCase() {
                if (null == inputCase) return;
                if (null == inputFramework) return;
                inputFramework.Cases.Add(inputCase.Title, inputCase);
                inputCase = null;
            }

            void SubmitFramework() {
                if (null == inputFramework) return;
                SubmitCase();
                List.Add(inputFramework);
                inputFramework = null;
            }
        }

        /// <summary>
        /// Load done - show info.
        /// </summary>
        private void LoadDone() {
            // Show load info.
            foreach (InputFramework item in List) {
                Writer?.WriteLine("- {0}: {1} items, {2} groups", item.Title, item.Cases.Count, item.GroupCounter.Count);
            }
            Writer?.WriteLine("Total {0} groups ({1})", GroupCounter.Count, GetGroupNames());
            Writer?.WriteLine("ArchitectureString:\t{0}", ArchitectureString);
            Writer?.WriteLine("ArchitectureFamily:\t{0}", ArchitectureFamily);
            //Writer?.WriteLine("ArchitectureSortCode:\t{0}", ArchitectureSortCode);
            Writer?.WriteLine("CpuModelName:\t{0}", CpuModelName);
            //Writer?.WriteLine("SourceBaseName:\t{0}", SourceBaseName);
            Writer?.WriteLine();
        }

        /// <summary>
        /// Get group names.
        /// </summary>
        /// <returns>Returns group names.</returns>
        public string GetGroupNames() {
            string[] list = GroupCounter.Keys.ToArray();
            string rt = string.Join(", ", list);
            return rt;
        }

        /// <summary>
        /// Process.
        /// </summary>
        private void Process() {
            Writer?.WriteLine("Folder:\t{0}", Folder);
            // folderFullPath
            string rootPath = Folder;
            if (string.IsNullOrEmpty(rootPath)) {
                rootPath = Environment.CurrentDirectory;
            }
            rootPath = Path.GetFullPath(rootPath);
            Writer?.WriteLine("Root path:\t{0}", rootPath);
            // enum.
            DirectoryInfo directoryInfo = new DirectoryInfo(rootPath);
            ProcessFolder(rootPath, directoryInfo);
            Writer?.WriteLine();
        }

        /// <summary>
        /// Process folder.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="directoryInfo">Current directory info.</param>
        private void ProcessFolder(string rootPath, DirectoryInfo directoryInfo) {
            string fullpath = "";
            try {
                fullpath = directoryInfo.FullName;
                //Writer?.WriteLine("{0}", directoryInfo.FullName);
                // sub folder.
                foreach (DirectoryInfo di in directoryInfo.GetDirectories()) {

                    ProcessFolder(rootPath, di);
                }
                // sub file.
                foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.md")) {
                    ProcessFile(rootPath, fileInfo);
                    throw new OperationCanceledException("[Debug] Only test one file. Will stop.");
                }
            } catch (OperationCanceledException) {
                throw;
            } catch (Exception ex) {
                Writer?.WriteLine("- {0}: {1}", fullpath, ex.Message);
            }
        }

        /// <summary>
        /// Process file.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="fileInfo">Current file info.</param>
        private void ProcessFile(string rootPath, FileInfo fileInfo) {
            string fileName = fileInfo.Name;
            string fileShortPath = BenchmarkStringUtil.GetSubPath(rootPath, fileInfo.FullName);
            string message = "";
            bool isEnd = false;
            try {
                if (fileName.IndexOf("_Group", comparisonType) >= 0) return;
                if (fileName.IndexOf("README.md", comparisonType) >= 0) return;
                if (fileName.IndexOf("sample.md", comparisonType) >= 0) return;
                message = ProcessFileBody(rootPath, fileInfo, fileShortPath);
            } catch (Exception ex) {
                if (!isEnd) {
                    message = ex.Message;
                }
            }
            Writer?.WriteLine("- {0}: {1}", fileShortPath, message);
        }

        /// <summary>
        /// Process file body.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="fileInfo">Current file info.</param>
        /// <param name="fileShortPath">File short path.</param>
        private string ProcessFileBody(string rootPath, FileInfo fileInfo, string fileShortPath) {
            string message = string.Empty;
            string filePath = fileInfo.FullName;
            // Load.
            string[]? lines = null;
            try {
                lines = File.ReadAllLines(filePath, encoding);
            } catch (Exception ex) {
                Writer?.WriteLine(ex);
            }
            if (null == lines) {
                lines = File.ReadAllLines(filePath);
            }
            if (null == lines) {
                return "Can't read file!";
            }
            // Parse.
            BenchmarkFile? benchmarkFile = ParseBenchmarkFile(lines, ref message);
            if (null == benchmarkFile) {
                if (string.IsNullOrEmpty(message)) {
                    message = "Not a benchmark results file!";
                }
                return message;
            }
            // Combine.
            const bool UseOutputOther = true; // [Debug] Output to other file.
            string OutputOtherSuffix = "_out.txt";
            if (UseOutputOther) {
                filePath += OutputOtherSuffix;
            }
            message = string.Empty;
            using (StreamWriter writer = new StreamWriter(filePath, false, encoding)) {
                CombineBenchmarkFile(writer, lines, benchmarkFile, ref message);
            }
            if (string.IsNullOrEmpty(message)) {
                //message = "Fail on CombineBenchmarkFile!";
                message = "OK.";
                if (UseOutputOther) {
                    message += string.Format(" Output to '{0}{1}'", fileShortPath, OutputOtherSuffix);
                }
            }
            return message;
        }

        /// <summary>
        /// Parse <see cref="BenchmarkFile"/>.
        /// </summary>
        /// <param name="lines">Text lines (文本行).</param>
        /// <param name="message">The message (消息).</param>
        /// <returns>Returns <see cref="BenchmarkFile"/>.</returns>
        private BenchmarkFile? ParseBenchmarkFile(string[] lines, ref string message) {
            const char TitleChar = '#';
            string CodeDelimiter = "```";
            BenchmarkFile? benchmarkFile = null;
            BenchmarkArchitecture? benchmarkArchitecture = null;
            BenchmarkCpu? benchmarkCpu = null;
            BenchmarkFramework? benchmarkFramework = null;
            BenchmarkCase? benchmarkCase = null;
            bool inCode = false;
            bool inCodeHeader = false;
            //bool inCase = false;
            string title, key;
            int m;
            for (int i = 0; i < lines.Length; ++i) {
                string line = lines[i];
                if (null == line) continue;
                if (line.StartsWith(CodeDelimiter)) {
                    inCode = !inCode;
                    if (!inCode) {
                        // Submit.
                        if (null != benchmarkCase) {
                            benchmarkCase = null;
                        }
                    } else {
                        // init var.
                        inCodeHeader = true;
                    }
                    //inCase = false;
                } else if (!inCode) {
                    // Out code.
                    if (line.StartsWith(TitleChar)) {
                        // Is title.
                        int cnt = BenchmarkStringUtil.GetSameCharCount(TitleChar, line);
                        title = line.Substring(cnt).Trim();
                        // Submit old.
                        if (cnt <= 3 && null != benchmarkFramework) {
                            benchmarkFramework = null;
                        }
                        if (cnt <= 2 && null != benchmarkCpu) {
                            benchmarkCpu = null;
                        }
                        if (cnt <= 1 && null!= benchmarkArchitecture) {
                            benchmarkArchitecture = null;
                        }
                        // Make new.
                        if (cnt == 1) {
                            key = title;
                            //val = string.Empty;
                            m = title.IndexOf('-');
                            if (m >= 0) {
                                key = title.Substring(0, m).Trim();
                            }
                            if (string.Equals("Benchmark", key, comparisonType)) {
                                // ok.
                                message = string.Empty;
                                if (null == benchmarkFile) {
                                    benchmarkFile = new BenchmarkFile();
                                    benchmarkFile.Title = title;
                                }
                            } else {
                                // not.
                                message = string.Format("Not a benchmark results file! Title is {0}", key);
                                return benchmarkFile;
                            }
                        }
                        if (cnt >= 2) {
                            if (cnt == 2 || null == benchmarkArchitecture) {
                                benchmarkArchitecture = new BenchmarkArchitecture();
                                benchmarkArchitecture.Title = title;
                                benchmarkFile?.List.Add(benchmarkArchitecture);
                            }
                        }
                        if (cnt >= 3) {
                            if (cnt == 3 || null == benchmarkCpu) {
                                benchmarkCpu = new BenchmarkCpu();
                                benchmarkCpu.Title = title;
                                benchmarkArchitecture?.List.Add(benchmarkCpu);
                            }
                        }
                        if (cnt >= 4) {
                            if (cnt == 4 || null == benchmarkFramework) {
                                benchmarkFramework = new BenchmarkFramework();
                                benchmarkFramework.Title = title;
                                benchmarkCpu?.List.Add(benchmarkFramework);
                            }
                        }
                    } else {
                        // Not title.
                    }
                } else {
                    // In code.
                    title = BenchmarkStringUtil.ExtractCaseTitle(line);
                    if (!string.IsNullOrEmpty(title)) {
                        inCodeHeader = false;
                        //inCase = true;
                        //SubmitCase();
                        benchmarkCase = new BenchmarkCase();
                        benchmarkCase.Title = title;
                        string baseTitle = BenchmarkStringUtil.GetCaseBaseTitle(title);
                        benchmarkCase.BaseTitle = baseTitle;
                        string primaryTitle = BenchmarkStringUtil.GetCasePrimaryTitle(title);
                        benchmarkCase.PrimaryTitle = primaryTitle;
                        if (null != benchmarkFramework) {
                            benchmarkFramework.Cases.Add(benchmarkCase.Title, benchmarkCase);
                            int num;
                            if (!benchmarkFramework.GroupCounter.TryGetValue(primaryTitle, out num)) {
                                num = 0;
                            }
                            benchmarkFramework.GroupCounter[primaryTitle] = num + 1;
                            // benchmarkCpu.
                            //if (!benchmarkCpu.GroupCounter.TryGetValue(primaryTitle, out num)) {
                            //    num = 0;
                            //}
                            //benchmarkCpu.GroupCounter[primaryTitle] = num + 1;
                        }
                    }
                    if (inCodeHeader) {
                    }
                }
            }
            // done.
            return benchmarkFile;
        }

        /// <summary>
        /// Combine benchmark file and output.
        /// </summary>
        /// <param name="writer">Output writer.</param>
        /// <param name="lines">Source text lines (源文本行).</param>
        /// <param name="benchmarkFile">Source  <see cref="BenchmarkFile"/>.</param>
        /// <param name="message">The message (消息).</param>
        private void CombineBenchmarkFile(StreamWriter writer, string[] lines, BenchmarkFile benchmarkFile, ref string message) {
            const char TitleChar = '#';
            string CodeDelimiter = "```";
            // insertArchitecture
            BenchmarkArchitecture? benchmarkArchitectureFound = benchmarkFile.List.FirstOrDefault(x=> string.Equals(x.Title, ArchitectureFamily, comparisonType));
            BenchmarkCpu? benchmarkCpuFound = null;
            bool insertArchitecture = false;
            bool insertCpu = false;
            if (null != benchmarkArchitectureFound) {
                benchmarkCpuFound = benchmarkArchitectureFound.List.FirstOrDefault(x => string.Equals(x.Title, SourceBaseName, comparisonType));
                if (null != benchmarkCpuFound) {
                    // OK.
                } else {
                    insertCpu = true;
                }
            } else {
                insertArchitecture = true;
            }
            // Group by CasePrimaryTitle.
            IDictionary<string, int> GroupCasePrimaryTitle = new SortedDictionary<string, int>();
            BenchmarkStringUtil.GroupByCasePrimaryTitle(GroupCasePrimaryTitle, benchmarkFile.List);
            // Body.
            BenchmarkArchitecture? benchmarkArchitecture = null;
            BenchmarkCpu? benchmarkCpu = null;
            BenchmarkFramework? benchmarkFramework = null;
            BenchmarkCase? benchmarkCase = null;
            InputFramework? inputFramework = null;
            InputCase? inputCase = null;
            bool isAllow = false;
            bool inCode = false;
            bool inCodeHeader = false;
            //bool inCase = false;
            bool needCopy = true;
            int countAdd = 0;
            int countRemove = 0;
            string title, key;
            int m;
            for (int i = 0; i < lines.Length; ++i) {
                string line = lines[i];
                if (null == line) continue;
                if (line.StartsWith(CodeDelimiter)) {
                    needCopy = true;
                    inCode = !inCode;
                    if (!inCode) {
                        // Submit.
                        if (null != benchmarkCase) {
                            benchmarkCase = null;
                        }
                    } else {
                        // init var.
                        inCodeHeader = true;
                    }
                    //inCase = false;
                } else if (!inCode) {
                    needCopy = true;
                    // Out code.
                    if (line.StartsWith(TitleChar)) {
                        // Is title.
                        int cnt = BenchmarkStringUtil.GetSameCharCount(TitleChar, line);
                        title = line.Substring(cnt).Trim();
                        // Submit old.
                        if (cnt <= 3) {
                            benchmarkCase = null;
                            benchmarkFramework = null;
                            inputCase = null;
                            inputFramework = null;
                        }
                        if (cnt <= 2) {
                            if (null!= benchmarkArchitecture && string.Equals(benchmarkArchitecture.Title, ArchitectureFamily, comparisonType)) {
                                if (insertCpu) {
                                    m = string.Compare(title, SourceBaseName, comparisonType);
                                    if (m > 0) {
                                        insertCpu = false;
                                        WriteFromInputCpu();
                                    }
                                }
                            }
                            benchmarkCpu = null;
                        }
                        if (cnt <= 1) {
                            benchmarkArchitecture = null;
                        }
                        // Make new.
                        if (cnt == 1) {
                            key = title;
                            //val = string.Empty;
                            m = title.IndexOf('-');
                            if (m >= 0) {
                                key = title.Substring(0, m).Trim();
                            }
                            if (string.Equals("Benchmark", key, comparisonType)) {
                                // ok.
                                message = string.Empty;
                                //if (null == benchmarkFile) {
                                //    benchmarkFile = new BenchmarkFile();
                                //    benchmarkFile.Title = title;
                                //}
                                isAllow = true;
                            } else {
                                // not.
                                message = string.Format("Not a benchmark results file! Title is {0}", key);
                                return;
                            }
                        }
                        if (isAllow) {
                            if (cnt >= 2) {
                                if (cnt == 2 || null == benchmarkArchitecture) {
                                    if (insertArchitecture) {
                                        string sortCode = BenchmarkStringUtil.GetArchitectureSortCode(title);
                                        m = string.Compare(sortCode, ArchitectureFamily, comparisonType);
                                        if (m > 0) {
                                            insertArchitecture = false;
                                            WriteFromInputArchitecture();
                                        }
                                    }
                                    benchmarkArchitecture = benchmarkFile.FindByTitle(title, comparisonType);
                                    if (null == benchmarkArchitecture) {
                                        message = string.Format("[WARN] Line {0}: Can't found architecture({1})!", 1 + i, title);
                                        return;
                                    }
                                }
                            }
                            if (cnt >= 3) {
                                if (cnt == 3 || null == benchmarkCpu) {
                                    if (insertCpu) {
                                        m = string.Compare(title, SourceBaseName, comparisonType);
                                        if (m > 0) {
                                            insertCpu = false;
                                            WriteFromInputCpu();
                                        }
                                    }
                                    benchmarkCpu = benchmarkArchitecture?.FindByTitle(title, comparisonType);
                                    if (null == benchmarkCpu) {
                                        message = string.Format("[WARN] Line {0}: Can't found cpu({1})!", 1 + i, title);
                                        return;
                                    }
                                }
                            }
                            if (cnt >= 4) {
                                if (cnt == 4 || null == benchmarkFramework) {
                                    benchmarkFramework = benchmarkCpu?.FindByTitle(title, comparisonType);
                                    if (null == benchmarkFramework) {
                                        message = string.Format("[WARN] Line {0}: Can't found framework({1})!", 1 + i, title);
                                        return;
                                    }
                                    inputCase = null;
                                    if (benchmarkCpu == benchmarkCpuFound) {
                                        inputFramework = List.FirstOrDefault(x => title.Equals(x.Title, comparisonType));
                                    }
                                }
                            }
                        }
                    } else {
                        // Not title.
                    }
                } else {
                    // In code.
                    title = BenchmarkStringUtil.ExtractCaseTitle(line);
                    if (!string.IsNullOrEmpty(title)) {
                        inCodeHeader = false;
                        needCopy = true;
                        //inCase = true;
                        //SubmitCase();
                        benchmarkCase = benchmarkFramework?.FindByTitle(title);
                        if (null == benchmarkCase) {
                            message = string.Format("[WARN] Line {0}: Can't found case({1})!", 1 + i, title);
                            return;
                        }
                        if (null != inputFramework) {
                            inputCase = inputFramework.FindByTitle(title);
                            if (null != inputCase) {
                                // Replace case.
                                needCopy = false;
                                WriteFromInputCase(inputCase);
                            }
                        }
                    } else {
                        //if (!needCopy && string.IsNullOrEmpty(line)) {
                        //    needCopy = true; // If empty line, will set needCopy.
                        //}
                    }
                    if (inCodeHeader) {
                    }
                }
                // needCopy.
                if (needCopy) {
                    writer.WriteLine(line);
                } else {
                    ++countRemove;
                }
            } // end for.
            // fix
            bool lastIsEmpty = true;
            if (lines.Length > 0) {
                lastIsEmpty = string.IsNullOrEmpty(lines[lines.Length - 1]);
            }
            if (insertCpu) {
                insertCpu = false;
                if (!lastIsEmpty) {
                    lastIsEmpty = true;
                    WriteFromInput();
                }
                WriteFromInputCpu();
            }
            if (insertArchitecture) {
                insertArchitecture = false;
                if (!lastIsEmpty) {
                    lastIsEmpty = true;
                    WriteFromInput();
                }
                WriteFromInputArchitecture();
            }
            // done.
            message = string.Format("The source is {0} lines. {1} lines added, {2} lines removed.", lines.Length, countAdd, countRemove);

            void WriteFromInput(string line = "") {
                writer.WriteLine(line);
                ++countAdd;
            }

            void WriteFromInputCase(InputCase? inputCase) {
                if (null == inputCase) return;
                foreach (string str in inputCase.Lines) {
                    WriteFromInput(str);
                }
                WriteFromInput();
            }

            void WriteFromInputFramework(InputFramework? inputFramework) {
                if (null == inputFramework) return;
                WriteFromInput(string.Format("#### {0}", inputFramework.Title));
                WriteFromInput();
                WriteFromInput("```");
                foreach(string s in inputFramework.Header) {
                    WriteFromInput(s);
                }
                foreach (KeyValuePair<string, InputCase> p in inputFramework.Cases) {
                    bool flag = GroupCasePrimaryTitle.ContainsKey(p.Value.PrimaryTitle);
                    if (flag) {
                        WriteFromInputCase(p.Value);
                    }
                }
                WriteFromInput("```");
                WriteFromInput();
            }

            void WriteFromInputCpu() {
                WriteFromInput(string.Format("### {0}", SourceBaseName));
                WriteFromInput(string.Format("`{0}`", CpuModelName));
                WriteFromInput();
                foreach (InputFramework aFramework in List) {
                    WriteFromInputFramework(aFramework);
                }
            }

            void WriteFromInputArchitecture() {
                WriteFromInput(string.Format("## {0}", ArchitectureFamily));
                WriteFromInput();
                WriteFromInputCpu();
            }

        }

    }
}
