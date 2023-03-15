# Benchmark - Widen
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4614.0
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	138.527	1892.364
SumWidenBcl	47.624	5504.454	2.908772
SumWidenVectorBase	46.783	5603.362	2.961039
SumWidenVectorBase_NPtr	307.358	852.895	0.450704
SumWidenVectorBase_NRef	316.543	828.148	0.437626
SumWidenVectorBase_NRef2	324.856	806.955	0.426427
SumWidenVectorBase_NRefInc	306.333	855.748	0.452211
SumWidenVectorBase_NRefInc2	315.376	831.210	0.439245
SumWidenVectorBase_Ptr	315.418	831.101	0.439186
SumWidenVectorBase_Ref	344.250	761.493	0.402403
SumWidenVectorBase_Ref2	334.475	783.747	0.414163
SumWidenVectorBase_RefInc	305.561	857.910	0.453354
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	301.085	870.665	0.460094
SumWidenVectorBase256_Ref	287.416	912.072	0.481975
SumWidenVectorBase256_Ref2	286.972	913.484	0.482721
SumWidenVectorBase256_RefI	292.151	897.288	0.474163
SumWidenVectorBase256_RefI2	297.717	880.516	0.465299
SumWidenVectorBase256_RefInc	296.628	883.747	0.467007
SumWidenVectorBase256_RefInc2	303.755	863.011	0.456049
SumWidenVectorTraits	47.162	5558.343	2.937249
SumWidenVectorTraits_Ptr	47.290	5543.271	2.929284

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	165.637	1582.643
SumWidenBcl	11.321	23156.001	14.631223
SumWidenVectorBase	11.410	22975.009	14.516863
SumWidenVectorTraits	11.399	22997.517	14.531085
SumWidenVectorTraits_Ptr	11.373	23050.289	14.564429

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	318.344	823.462
SumWidenBcl	43.005	6095.680	7.402508
SumWidenVectorBase	45.456	5766.939	7.003289
SumWidenVectorTraits	44.167	5935.235	7.207665
SumWidenVectorTraits_Ptr	44.335	5912.864	7.180498

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	139.705	1876.407
SumWidenBcl	47.976	5464.032	2.911965
SumWidenVectorBase	47.639	5502.738	2.932593
SumWidenVectorBase_NPtr	313.176	837.050	0.446092
SumWidenVectorBase_NRef	322.137	813.765	0.433683
SumWidenVectorBase_NRef2	331.872	789.894	0.420961
SumWidenVectorBase_NRefInc	312.515	838.820	0.447035
SumWidenVectorBase_NRefInc2	321.009	816.625	0.435207
SumWidenVectorBase_Ptr	320.308	818.412	0.436159
SumWidenVectorBase_Ref	345.455	758.837	0.404409
SumWidenVectorBase_Ref2	336.783	778.377	0.414823
SumWidenVectorBase_RefInc	306.454	855.410	0.455876
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	304.038	862.207	0.459499
SumWidenVectorBase256_Ref	292.374	896.605	0.477831
SumWidenVectorBase256_Ref2	288.437	908.843	0.484353
SumWidenVectorBase256_RefI	295.127	888.243	0.473374
SumWidenVectorBase256_RefI2	292.471	896.309	0.477673
SumWidenVectorBase256_RefInc	291.639	898.864	0.479035
SumWidenVectorBase256_RefInc2	299.734	874.589	0.466098
SumWidenVectorTraits	47.460	5523.469	2.943641
SumWidenVectorTraits_Ptr	49.151	5333.459	2.842378

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	166.624	1573.271
SumWidenBcl	11.309	23180.871	14.734193
SumWidenVectorBase	11.168	23473.410	14.920136
SumWidenVectorTraits	11.100	23617.189	15.011524
SumWidenVectorTraits_Ptr	11.060	23702.973	15.066050

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194
SumWidenScalar	313.736	835.557
SumWidenBcl	44.021	5954.967	7.126941
SumWidenVectorBase	48.745	5377.832	6.436223
SumWidenVectorTraits	49.101	5338.917	6.389649
SumWidenVectorTraits_Ptr	46.431	5645.845	6.756982

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	163.468	1603.638
SumWidenBcl	48.546	5399.913	3.367289
SumWidenVectorBase	52.876	4957.706	3.091537
SumWidenVectorBase_NPtr	313.223	836.924	0.521891
SumWidenVectorBase_NRef	322.688	812.376	0.506583
SumWidenVectorBase_NRef2	330.329	793.585	0.494866
SumWidenVectorBase_NRefInc	310.509	844.241	0.526453
SumWidenVectorBase_NRefInc2	320.930	816.826	0.509358
SumWidenVectorBase_Ptr	345.021	759.792	0.473793
SumWidenVectorBase_Ref	350.784	747.309	0.466008
SumWidenVectorBase_Ref2	337.246	777.308	0.484715
SumWidenVectorBase_RefInc	307.232	853.245	0.532068
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	301.746	868.756	0.541741
SumWidenVectorBase256_Ref	287.844	910.714	0.567905
SumWidenVectorBase256_Ref2	288.081	909.965	0.567438
SumWidenVectorBase256_RefI	289.393	905.840	0.564865
SumWidenVectorBase256_RefI2	290.008	903.918	0.563667
SumWidenVectorBase256_RefInc	297.210	882.015	0.550009
SumWidenVectorBase256_RefInc2	305.001	859.486	0.535960
SumWidenVectorTraits	37.063	7072.978	4.410582
SumWidenVectorTraits_Ptr	39.422	6649.649	4.146602
SumWidenVector128Traits	1215.021	215.753	0.134539
SumWidenVector256Traits	43.355	6046.464	3.770467

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	195.085	1343.746
SumWidenBcl	12.738	20578.895	15.314577
SumWidenVectorBase	12.710	20625.283	15.349099
SumWidenVectorTraits	8.663	30259.862	22.519042
SumWidenVectorTraits_Ptr	8.775	29872.378	22.230680
SumWidenVector128Traits	397.916	658.793	0.490266
SumWidenVector256Traits	9.150	28649.296	21.320477

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	331.983	789.632
SumWidenBcl	55.153	4753.033	6.019304
SumWidenVectorBase	72.963	3592.827	4.550003
SumWidenVectorTraits	52.860	4959.235	6.280440
SumWidenVectorTraits_Ptr	57.560	4554.274	5.767593
SumWidenVector128Traits	1201.076	218.258	0.276404
SumWidenVector256Traits	41.497	6317.201	8.000187

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 5

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	160.643	1631.846
SumWidenBcl	47.804	5483.740	3.360452
SumWidenVectorBase	48.069	5453.518	3.341932
SumWidenVectorBase_NPtr	317.711	825.101	0.505624
SumWidenVectorBase_NRef	320.082	818.990	0.501879
SumWidenVectorBase_NRef2	328.329	798.419	0.489273
SumWidenVectorBase_NRefInc	313.366	836.544	0.512636
SumWidenVectorBase_NRefInc2	316.260	828.889	0.507946
SumWidenVectorBase_Ptr	325.455	805.469	0.493594
SumWidenVectorBase_Ref	345.792	758.097	0.464564
SumWidenVectorBase_Ref2	333.913	785.066	0.481091
SumWidenVectorBase_RefInc	304.613	860.581	0.527367
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	315.923	829.771	0.508486
SumWidenVectorBase256_Ref	267.228	980.976	0.601145
SumWidenVectorBase256_Ref2	277.249	945.519	0.579417
SumWidenVectorBase256_RefI	278.683	940.652	0.576434
SumWidenVectorBase256_RefI2	280.265	935.342	0.573181
SumWidenVectorBase256_RefInc	287.565	911.599	0.558631
SumWidenVectorBase256_RefInc2	289.569	905.291	0.554765
SumWidenVectorTraits	35.570	7369.780	4.516223
SumWidenVectorTraits_Ptr	35.525	7379.089	4.521928
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1155.798	226.808	0.138989
SumWidenVector256Traits	36.914	7101.392	4.351754

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	167.264	1567.251
SumWidenBcl	11.243	23316.407	14.877261
SumWidenVectorBase	12.370	21191.863	13.521676
SumWidenVectorTraits	8.873	29542.919	18.850148
SumWidenVectorTraits_Ptr	8.507	30815.069	19.661856
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	392.683	667.572	0.425951
SumWidenVector256Traits	8.734	30014.597	19.151107

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	359.386	729.421
SumWidenBcl	54.742	4788.705	6.565073
SumWidenVectorBase	52.098	5031.759	6.898288
SumWidenVectorTraits	48.321	5425.087	7.437520
SumWidenVectorTraits_Ptr	52.687	4975.496	6.821154
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1152.325	227.491	0.311879
SumWidenVector256Traits	49.271	5320.413	7.294018

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 6

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.12
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.12\
RuntimeInformation.FrameworkDescription:	.NET 6.0.12
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.12/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	141.057	1858.425
SumWidenBcl	49.447	5301.516	2.852693
SumWidenVectorBase	47.718	5493.625	2.956066
SumWidenVectorBase_NPtr	326.834	802.071	0.431586
SumWidenVectorBase_NRef	326.039	804.027	0.432639
SumWidenVectorBase_NRef2	331.889	789.856	0.425013
SumWidenVectorBase_NRefInc	305.152	859.059	0.462251
SumWidenVectorBase_NRefInc2	314.692	833.018	0.448239
SumWidenVectorBase_Ptr	325.621	805.060	0.433195
SumWidenVectorBase_Ref	345.659	758.389	0.408082
SumWidenVectorBase_Ref2	338.963	773.371	0.416143
SumWidenVectorBase_RefInc	307.238	853.226	0.459113
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	327.646	800.082	0.430516
SumWidenVectorBase256_Ref	275.450	951.692	0.512096
SumWidenVectorBase256_Ref2	275.607	951.150	0.511804
SumWidenVectorBase256_RefI	285.033	919.697	0.494880
SumWidenVectorBase256_RefI2	286.281	915.687	0.492722
SumWidenVectorBase256_RefInc	292.538	896.101	0.482183
SumWidenVectorBase256_RefInc2	300.338	872.829	0.469660
SumWidenVectorTraits	36.955	7093.623	3.817008
SumWidenVectorTraits_Ptr	36.702	7142.416	3.843263
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1163.341	225.337	0.121252
SumWidenVector256Traits	37.208	7045.344	3.791030

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	156.279	1677.409
SumWidenBcl	11.358	23079.382	13.758947
SumWidenVectorBase	11.410	22975.035	13.696740
SumWidenVectorTraits	8.044	32589.841	19.428679
SumWidenVectorTraits_Ptr	8.310	31546.926	18.806937
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	384.432	681.899	0.406519
SumWidenVector256Traits	8.769	29893.269	17.821097

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	332.192	789.135
SumWidenBcl	50.972	5142.908	6.517145
SumWidenVectorBase	53.356	4913.068	6.225890
SumWidenVectorTraits	50.025	5240.250	6.640499
SumWidenVectorTraits_Ptr	51.004	5139.655	6.513023
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	1181.589	221.857	0.281140
SumWidenVector256Traits	50.199	5222.126	6.617531

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 7

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.1
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.1\
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	X64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	159.540	1643.122
SumWidenBcl	33.075	7925.839	4.823646
SumWidenVectorBase	33.004	7942.738	4.833931
SumWidenVectorBase_NPtr	284.550	921.257	0.560675
SumWidenVectorBase_NRef	283.474	924.754	0.562803
SumWidenVectorBase_NRef2	287.798	910.861	0.554348
SumWidenVectorBase_NRefInc	301.454	869.598	0.529235
SumWidenVectorBase_NRefInc2	316.611	827.968	0.503900
SumWidenVectorBase_Ptr	308.294	850.306	0.517494
SumWidenVectorBase_Ref	308.669	849.274	0.516866
SumWidenVectorBase_Ref2	294.000	891.647	0.542654
SumWidenVectorBase_RefInc	303.995	862.330	0.524812
SumWidenVectorBase128_Ptr	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_Ref2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefI2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase128_RefInc2	Run fail! Vector byte size mismatch(32!=16) !
SumWidenVectorBase256_Ptr	262.080	1000.243	0.608745
SumWidenVectorBase256_Ref	268.778	975.318	0.593576
SumWidenVectorBase256_Ref2	274.582	954.704	0.581030
SumWidenVectorBase256_RefI	274.214	955.983	0.581809
SumWidenVectorBase256_RefI2	284.575	921.177	0.560626
SumWidenVectorBase256_RefInc	287.562	911.609	0.554803
SumWidenVectorBase256_RefInc2	293.272	893.858	0.544000
SumWidenVectorTraits	34.200	7664.997	4.664898
SumWidenVectorTraits_Ptr	33.462	7834.110	4.767820
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	60.779	4313.075	2.624927
SumWidenVector256Traits	33.727	7772.580	4.730373

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	159.379	1644.779
SumWidenBcl	7.551	34717.013	21.107400
SumWidenVectorBase	8.224	31875.924	19.380062
SumWidenVectorTraits	8.292	31613.650	19.220604
SumWidenVectorTraits_Ptr	8.482	30905.000	18.789756
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	15.462	16953.979	10.307753
SumWidenVector256Traits	8.152	32157.599	19.551316

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	318.577	822.860
SumWidenBcl	46.770	5604.959	6.811557
SumWidenVectorBase	49.160	5332.513	6.480460
SumWidenVectorTraits	48.375	5419.031	6.585603
SumWidenVectorTraits_Ptr	47.651	5501.386	6.685687
SumWidenVector128_Arm	Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64	Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits	78.636	3333.653	4.051300
SumWidenVector256Traits	45.129	5808.735	7.059200

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

## Arm

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	3.1.31
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.31
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	350.673	747.545
SumWidenBcl	80.034	3275.413	4.381562
SumWidenVectorBase	74.290	3528.655	4.720327
SumWidenVectorBase_NPtr	553.162	473.901	0.633943
SumWidenVectorBase_NRef	487.909	537.281	0.718727
SumWidenVectorBase_NRef2	491.072	533.820	0.714098
SumWidenVectorBase_NRefInc	499.411	524.907	0.702174
SumWidenVectorBase_NRefInc2	499.274	525.050	0.702366
SumWidenVectorBase_Ptr	555.679	471.754	0.631072
SumWidenVectorBase_Ref	490.487	534.456	0.714949
SumWidenVectorBase_Ref2	491.527	533.326	0.713437
SumWidenVectorBase_RefInc	871.988	300.628	0.402154
SumWidenVectorBase128_Ptr	550.195	476.456	0.637362
SumWidenVectorBase128_Ref	493.607	531.078	0.710430
SumWidenVectorBase128_Ref2	496.819	527.645	0.705838
SumWidenVectorBase128_RefI	498.996	525.343	0.702758
SumWidenVectorBase128_RefI2	499.592	524.716	0.701919
SumWidenVectorBase128_RefInc	492.322	532.464	0.712284
SumWidenVectorBase128_RefInc2	491.067	533.825	0.714105
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	74.268	3529.716	4.721746
SumWidenVectorTraits_Ptr	74.211	3532.433	4.725380
SumWidenVector128Traits	1173.705	223.347	0.298775
SumWidenVector256Traits	1368.411	191.568	0.256263

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	341.282	768.115
SumWidenBcl	18.274	14345.430	18.676154
SumWidenVectorBase	18.289	14333.083	18.660080
SumWidenVectorTraits	19.830	13219.564	17.210401
SumWidenVectorTraits_Ptr	19.849	13207.038	17.194095
SumWidenVector128Traits	589.657	444.570	0.578781
SumWidenVector256Traits	538.768	486.562	0.633450

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	291.126	900.448
SumWidenBcl	80.402	3260.421	3.620886
SumWidenVectorBase	80.575	3253.398	3.613087
SumWidenVectorTraits	80.437	3259.004	3.619313
SumWidenVectorTraits_Ptr	74.780	3505.519	3.893082
SumWidenVector128Traits	1308.674	200.313	0.222459
SumWidenVector256Traits	1391.062	188.449	0.209283

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 5

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	349.356	750.363
SumWidenBcl	83.996	3120.909	4.159198
SumWidenVectorBase	75.855	3455.858	4.605581
SumWidenVectorBase_NPtr	538.688	486.634	0.648532
SumWidenVectorBase_NRef	492.923	531.815	0.708744
SumWidenVectorBase_NRef2	497.116	527.330	0.702766
SumWidenVectorBase_NRefInc	512.768	511.233	0.681314
SumWidenVectorBase_NRefInc2	503.681	520.456	0.693606
SumWidenVectorBase_Ptr	542.737	483.004	0.643694
SumWidenVectorBase_Ref	493.280	531.430	0.708231
SumWidenVectorBase_Ref2	494.127	530.519	0.707016
SumWidenVectorBase_RefInc	511.617	512.384	0.682848
SumWidenVectorBase128_Ptr	545.258	480.771	0.640718
SumWidenVectorBase128_Ref	518.002	506.068	0.674431
SumWidenVectorBase128_Ref2	515.241	508.779	0.678044
SumWidenVectorBase128_RefI	513.844	510.162	0.679887
SumWidenVectorBase128_RefI2	512.260	511.740	0.681990
SumWidenVectorBase128_RefInc	509.427	514.586	0.685783
SumWidenVectorBase128_RefInc2	503.434	520.712	0.693947
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	84.107	3116.778	4.153693
SumWidenVectorTraits_Ptr	76.013	3448.677	4.596010
SumWidenVector128_Arm	88.228	2971.200	3.959682
SumWidenVector128Traits	88.093	2975.763	3.965765
SumWidenVector256Traits	854.042	306.945	0.409062

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	352.812	743.012
SumWidenBcl	20.848	12573.830	16.922777
SumWidenVectorBase	21.189	12371.942	16.651061
SumWidenVectorTraits	18.702	14017.035	18.865146
SumWidenVectorTraits_Ptr	20.149	13009.998	17.509803
SumWidenVector128_Arm	21.900	11970.238	16.110418
SumWidenVector128Traits	21.643	12112.350	16.301683
SumWidenVector256Traits	409.297	640.474	0.861997

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	290.752	901.608
SumWidenBcl	76.838	3411.624	3.783933
SumWidenVectorBase	76.879	3409.835	3.781949
SumWidenVectorTraits	83.139	3153.065	3.497157
SumWidenVectorTraits_Ptr	76.478	3427.690	3.801752
SumWidenVector128_Arm	647.481	404.867	0.449050
SumWidenVector128_ArmB64	90.509	2896.346	3.212423
SumWidenVector128Traits	89.158	2940.233	3.261099
SumWidenVector256Traits	892.728	293.644	0.325689

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 6

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	6.0.11
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/
RuntimeInformation.FrameworkDescription:	.NET 6.0.11
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	349.740	749.539
SumWidenBcl	84.100	3117.056	4.158632
SumWidenVectorBase	76.598	3422.325	4.565909
SumWidenVectorBase_NPtr	545.671	480.407	0.640937
SumWidenVectorBase_NRef	493.133	531.589	0.709222
SumWidenVectorBase_NRef2	706.852	370.861	0.494786
SumWidenVectorBase_NRefInc	513.335	510.669	0.681311
SumWidenVectorBase_NRefInc2	506.059	518.011	0.691107
SumWidenVectorBase_Ptr	545.640	480.434	0.640973
SumWidenVectorBase_Ref	494.422	530.203	0.707373
SumWidenVectorBase_Ref2	495.792	528.738	0.705418
SumWidenVectorBase_RefInc	513.797	510.209	0.680697
SumWidenVectorBase128_Ptr	538.760	486.569	0.649158
SumWidenVectorBase128_Ref	519.501	504.607	0.673224
SumWidenVectorBase128_Ref2	519.161	504.938	0.673665
SumWidenVectorBase128_RefI	515.641	508.385	0.678264
SumWidenVectorBase128_RefI2	511.220	512.782	0.684130
SumWidenVectorBase128_RefInc	509.043	514.974	0.687055
SumWidenVectorBase128_RefInc2	499.097	525.236	0.700746
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	76.616	3421.535	4.564854
SumWidenVectorTraits_Ptr	84.803	3091.220	4.124164
SumWidenVector128_Arm	88.431	2964.398	3.954963
SumWidenVector128Traits	88.071	2976.512	3.971126
SumWidenVector256Traits	858.303	305.421	0.407479

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	309.364	847.364
SumWidenBcl	18.680	14033.774	16.561687
SumWidenVectorBase	20.875	12557.837	14.819889
SumWidenVectorTraits	18.691	14024.904	16.551220
SumWidenVectorTraits_Ptr	18.898	13871.441	16.370114
SumWidenVector128_Arm	21.812	12018.280	14.183141
SumWidenVector128Traits	21.851	11996.728	14.157707
SumWidenVector256Traits	409.674	639.884	0.755147

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	316.753	827.598
SumWidenBcl	76.679	3418.702	4.130874
SumWidenVectorBase	83.013	3157.879	3.815717
SumWidenVectorTraits	83.883	3125.112	3.776124
SumWidenVectorTraits_Ptr	77.160	3397.429	4.105169
SumWidenVector128_Arm	649.231	403.776	0.487889
SumWidenVector128_ArmB64	89.950	2914.340	3.521445
SumWidenVector128Traits	89.557	2927.117	3.536883
SumWidenVector256Traits	893.955	293.241	0.354327

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```

#### .NET 7

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	7.0.1
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	Arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[WidenBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	-829396443174
SumWidenScalar	210.988	1242.461
SumWidenBcl	69.633	3764.642	3.029987
SumWidenVectorBase	69.652	3763.612	3.029158
SumWidenVectorBase_NPtr	694.587	377.410	0.303760
SumWidenVectorBase_NRef	707.146	370.707	0.298365
SumWidenVectorBase_NRef2	477.128	549.421	0.442204
SumWidenVectorBase_NRefInc	480.178	545.930	0.439394
SumWidenVectorBase_NRefInc2	480.847	545.171	0.438783
SumWidenVectorBase_Ptr	480.263	545.834	0.439317
SumWidenVectorBase_Ref	625.166	419.319	0.337490
SumWidenVectorBase_Ref2	475.495	551.308	0.443722
SumWidenVectorBase_RefInc	480.217	545.887	0.439359
SumWidenVectorBase128_Ptr	491.045	533.849	0.429670
SumWidenVectorBase128_Ref	491.789	533.041	0.429021
SumWidenVectorBase128_Ref2	490.784	534.133	0.429899
SumWidenVectorBase128_RefI	488.859	536.236	0.431592
SumWidenVectorBase128_RefI2	489.379	535.667	0.431134
SumWidenVectorBase128_RefInc	487.674	537.539	0.432640
SumWidenVectorBase128_RefInc2	486.533	538.800	0.433655
SumWidenVectorBase256_Ptr	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_Ref2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefI2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorBase256_RefInc2	Run fail! Vector byte size mismatch(16!=32) !
SumWidenVectorTraits	69.519	3770.815	3.034956
SumWidenVectorTraits_Ptr	69.663	3763.011	3.028675
SumWidenVector128_Arm	69.797	3755.802	3.022872
SumWidenVector128Traits	69.894	3750.581	3.018670
SumWidenVector256Traits	2305.560	113.701	0.091513

[WidenBenchmark_SByte(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	6514
SumWidenScalar	215.225	1218.001
SumWidenBcl	17.111	15320.446	12.578356
SumWidenVectorBase	17.264	15184.279	12.466561
SumWidenVectorTraits	17.118	15314.270	12.573285
SumWidenVectorTraits_Ptr	16.914	15498.275	12.724357
SumWidenVector128_Arm	17.031	15392.120	12.637202
SumWidenVector128Traits	17.156	15280.250	12.545355
SumWidenVector256Traits	1534.270	170.859	0.140278

[WidenBenchmark_Single(262144)]
---
NAME	US	MOPS	SCALE
# SumWidenScalar	130888.73095194018
SumWidenScalar	211.092	1241.846
SumWidenBcl	73.359	3573.416	2.877502
SumWidenVectorBase	73.413	3570.790	2.875388
SumWidenVectorTraits	73.414	3570.762	2.875365
SumWidenVectorTraits_Ptr	73.405	3571.221	2.875735
SumWidenVector128_Arm	433.601	604.574	0.486834
SumWidenVector128_ArmB64	73.270	3577.799	2.881031
SumWidenVector128Traits	73.229	3579.760	2.882611
SumWidenVector256Traits	2449.326	107.027	0.086184

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
```
