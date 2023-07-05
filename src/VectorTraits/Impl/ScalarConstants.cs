﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants of scalar (标量的常数).
    /// </summary>
    public static class ScalarConstants {

        // == Integer value ==
        /// <summary>Integer - `(long)pow(2, 52) = 0x00100000_00000000 = 4503599627370496`.</summary>
        public const long Int_2Pow52 = 0x00100000_00000000;


        // == Half (s1e5m10, sometimes called FP16 or float16) ==
        // -- Half - Number struct --
        /// <summary>Half - Sign bit size (符号位数). Value is `1`.</summary>
        public const int Half_SignBits = 1;
        /// <summary>Half - Exponent bit size (指数位数). Value is `5`.</summary>
        public const int Half_ExponentBits = 5;
        /// <summary>Half - Mantissa bit size (尾数位数). Value is `10`.</summary>
        public const int Half_MantissaBits = 10;
        /// <summary>Half - Sign shift bit (符号位移). Value is `10+5=15`.</summary>
        public const int Half_SignShift = Half_MantissaBits + Half_ExponentBits;
        /// <summary>Half - Exponent shift bit (指数位移). Value is `10`.</summary>
        public const int Half_ExponentShift = Half_MantissaBits;
        /// <summary>Half - Mantissa shift bit (尾数位移). Value is `0`.</summary>
        public const int Half_MantissaShift = 0;
        /// <summary>Half - Exponent bias (指数偏移值). Value is `15`.</summary>
        public const int Half_ExponentBias = 15;
        /// <summary>Half - The minimum value for exponential bias (指数偏移时的最小值). Value is `-14`.</summary>
        public const int Half_ExponentBias_Min = -14;
        /// <summary>Half - The maximum value for exponential bias (指数偏移时的最大值). Value is `15`.</summary>
        public const int Half_ExponentBias_Max = 15;
        /// <summary>Half - Exponent value at infinite or NaN (无穷或非数时的指数值). Value is `31`.</summary>
        public const int Half_ExponentInfinity = 31;
        /// <summary>Half - Sign mask (符号掩码). Value is `0x8000`.</summary>
        public const short Half_SignMask = short.MinValue;
        /// <summary>Half - Exponent mask (指数掩码). Value is `0x7C00`.</summary>
        public const short Half_ExponentMask = 0x7C00;
        /// <summary>Half - Mantissa mask (尾数掩码). Value is `0x03FF`.</summary>
        public const short Half_MantissaMask = 0x03FF;
        /// <summary>Half - Non-sign mask (非符号掩码). Value is `0x7FFF`.</summary>
        public const short Half_NonSignMask = ~Half_SignMask;
        /// <summary>Half - Non-exponent mask (非指数掩码). Value is `0x83FF`.</summary>
        public const short Half_NonExponentMask = ~Half_ExponentMask;
        /// <summary>Half - Non-mantissa mask (非尾数掩码). Value is `0xFC00`.</summary>
        public const short Half_NonMantissaMask = ~Half_MantissaMask;

        // -- HalfBit: Bit of Half --

        // -- HalfVal: Value of Half --


        // == Single (s1e8m23) ==
        // -- Single - Number struct --
        /// <summary>Single - Sign bit size (符号位数). Value is `1`.</summary>
        public const int Single_SignBits = 1;
        /// <summary>Single - Exponent bit size (指数位数). Value is `8`.</summary>
        public const int Single_ExponentBits = 8;
        /// <summary>Single - Mantissa bit size (尾数位数). Value is `23`.</summary>
        public const int Single_MantissaBits = 23;
        /// <summary>Single - Sign shift bit (符号位移). Value is `23+8=31`.</summary>
        public const int Single_SignShift = Single_MantissaBits + Single_ExponentBits;
        /// <summary>Single - Exponent shift bit (指数位移). Value is `23`.</summary>
        public const int Single_ExponentShift = Single_MantissaBits;
        /// <summary>Single - Mantissa shift bit (尾数位移). Value is `0`.</summary>
        public const int Single_MantissaShift = 0;
        /// <summary>Single - Exponent bias (指数偏移值). Value is `127`.</summary>
        public const int Single_ExponentBias = 127;
        /// <summary>Single - The minimum value for exponential bias (指数偏移时的最小值). Value is `-126`.</summary>
        public const int Single_ExponentBias_Min = -126;
        /// <summary>Single - The maximum value for exponential bias (指数偏移时的最大值). Value is `127`.</summary>
        public const int Single_ExponentBias_Max = 127;
        /// <summary>Single - Exponent value at infinite or NaN (无穷或非数时的指数值). Value is `255`.</summary>
        public const int Single_ExponentInfinity = 255;
        /// <summary>Single - Sign mask (符号掩码). Binary is `0x80000000`.</summary>
        public const int Single_SignMask = int.MinValue;
        /// <summary>Single - Exponent mask (指数掩码). Binary is `0x7F800000`.</summary>
        public const int Single_ExponentMask = 0x7F800000;
        /// <summary>Single - Mantissa mask (尾数掩码). Binary is `0x007FFFFF`.</summary>
        public const int Single_MantissaMask = 0x007FFFFF;
        /// <summary>Single - Non-sign mask (非符号掩码). Binary is `0x7FFFFFFF`.</summary>
        public const int Single_NonSignMask = ~Single_SignMask;
        /// <summary>Single - Non-exponent mask (非指数掩码). Binary is `0x807FFFFF`.</summary>
        public const int Single_NonExponentMask = ~Single_ExponentMask;
        /// <summary>Single - Non-mantissa mask (非尾数掩码). Binary is `0xFF800000`.</summary>
        public const int Single_NonMantissaMask = ~Single_MantissaMask;

        // -- SingleBit: Bit of Single --
        /// <summary>SingleBit - `(float)0x80000000 = -pow(2, 31) = -2147483648`. Binary is `0xCF000000`.</summary>
        public const int SingleBit_Negative2Pow31 = unchecked((int)0xCF000000U); // BitConverter.SingleToInt32Bits((float)-Math.Pow(2, 31)).ToString("X")
        /// <summary>SingleBit - `-pow(2, 32) = -4294967296`. Binary is `0xCF800000`.</summary>
        public const int SingleBit_Negative2Pow32 = unchecked((int)0xCF800000U);

        /// <summary>SingleBit - `(float)0x00800000 = pow(2, 23) = 8388608`. Binary is `0x4B000000`.</summary>
        public const int SingleBit_2Pow23 = 0x4B000000; // BitConverter.SingleToInt32Bits((float)Math.Pow(2, 23)).ToString("X")
        /// <summary>SingleBit - `(float)0x80000000U = pow(2, 31) = 2147483648`. Binary is `0x4F000000`.</summary>
        public const int SingleBit_2Pow31 = 0x4F000000;
        /// <summary>SingleBit - `pow(2, 32) = 4294967296`. Binary is `0x4F800000`.</summary>
        public const int SingleBit_2Pow32 = 0x4F800000;

        // -- SingleVal: Value of Single --
        /// <summary>SingleVal - Sign mask (符号掩码). Binary is `0x80000000`.</summary>
        public const float SingleVal_SignMask = -0.0f; // float.NegativeZero
        /// <summary>SingleVal - Exponent mask (指数掩码). Binary is `0x7F800000`.</summary>
        public const float SingleVal_ExponentMask = float.PositiveInfinity;
        /// <summary>SingleVal - Mantissa mask (尾数掩码). Binary is `0x007FFFFF`.</summary>
        public const float SingleVal_MantissaMask = 1.1754942E-38f; // BitConverter.Int32BitsToSingle(0x007FFFFF)
        // /// <summary>SingleVal - Non-sign mask (非符号掩码). Binary is `0x7FFFFFFF`.</summary>
        // public const float SingleVal_NonSignMask = float.NaN; // The `0x7FFFFFFF` can't be equal to `BitConverter.SingleToInt32Bits(float.NaN).ToString("X")` .
        /// <summary>SingleVal - Non-exponent mask (非指数掩码). Binary is `0x807FFFFF`.</summary>
        public const float SingleVal_NonExponentMask = -1.1754942E-38f; // BitConverter.Int32BitsToSingle(unchecked((int)0x807FFFFF))
        /// <summary>SingleVal - Non-mantissa mask (非尾数掩码). Binary is `0xFF800000`.</summary>
        public const float SingleVal_NonMantissaMask = float.NegativeInfinity;

        /// <summary>SingleVal - `(float)0x80000000 = -pow(2, 31) = -2147483648`. Binary is `0xCF000000`.</summary>
        public const float SingleVal_Negative2Pow31 = 0x80000000;
        /// <summary>SingleVal - `-pow(2, 32) = -4294967296`. Binary is `0xCF800000`.</summary>
        public const float SingleVal_Negative2Pow32 = -4294967296;

        /// <summary>SingleVal - `(float)0x00800000 = pow(2, 23) = 8388608`. Binary is `0x4B000000`.</summary>
        public const float SingleVal_2Pow23 = 0x00800000;
        /// <summary>SingleVal - `(float)0x80000000U = pow(2, 31) = 2147483648`. Binary is `0x4F000000`.</summary>
        public const float SingleVal_2Pow31 = 0x80000000U;
        /// <summary>SingleVal - `pow(2, 32) = 4294967296`. Binary is `0x4F800000`.</summary>
        public const float SingleVal_2Pow32 = 4294967296;


        // == Double (s1e11m52) ==
        // -- Double - Number struct --
        /// <summary>Double - Sign bit size (符号位数). Value is `1`.</summary>
        public const int Double_SignBits = 1;
        /// <summary>Double - Exponent bit size (指数位数). Value is `11`.</summary>
        public const int Double_ExponentBits = 11;
        /// <summary>Double - Mantissa bit size (尾数位数). Value is `52`.</summary>
        public const int Double_MantissaBits = 52;
        /// <summary>Double - Sign shift bit (符号位移). Value is `52+11=63`.</summary>
        public const int Double_SignShift = Double_MantissaBits + Double_ExponentBits;
        /// <summary>Double - Exponent shift bit (指数位移). Value is `52`.</summary>
        public const int Double_ExponentShift = Double_MantissaBits;
        /// <summary>Double - Mantissa shift bit (尾数位移). Value is `0`.</summary>
        public const int Double_MantissaShift = 0;
        /// <summary>Double - Exponent bias (指数偏移值). Value is `1023`.</summary>
        public const int Double_ExponentBias = 1023;
        /// <summary>Double - The minimum value for exponential bias (指数偏移时的最小值). Value is `-1022`.</summary>
        public const int Double_ExponentBias_Min = -1022;
        /// <summary>Double - The maximum value for exponential bias (指数偏移时的最大值). Value is `1023`.</summary>
        public const int Double_ExponentBias_Max = 1023;
        /// <summary>Double - Exponent value at infinite or NaN (无穷或非数时的指数值). Value is `2047`.</summary>
        public const int Double_ExponentInfinity = 2047;
        /// <summary>Double - Sign mask (符号掩码). Binary is `0x8000000000000000L`.</summary>
        public const long Double_SignMask = long.MinValue;
        /// <summary>Double - Exponent mask (指数掩码). Binary is `0x7FF0000000000000L`.</summary>
        public const long Double_ExponentMask = 0x7FF0000000000000L;
        /// <summary>Double - Mantissa mask (尾数掩码). Binary is `0x000FFFFFFFFFFFFFL`.</summary>
        public const long Double_MantissaMask = 0x000FFFFFFFFFFFFFL;
        /// <summary>Double - Non-sign mask (非符号掩码). Binary is `0x7FFFFFFFFFFFFFFFL`.</summary>
        public const long Double_NonSignMask = ~Double_SignMask;
        /// <summary>Double - Non-exponent mask (非指数掩码). Binary is `0x800FFFFFFFFFFFFFL`.</summary>
        public const long Double_NonExponentMask = ~Double_ExponentMask;
        /// <summary>Double - Non-mantissa mask (非尾数掩码). Binary is `0xFFF0000000000000L`.</summary>
        public const long Double_NonMantissaMask = ~Double_MantissaMask;

        // -- DoubleBit: Bit of Double --
        /// <summary>DoubleBit - `(double)0x0008000000000000 = pow(2, 51) = 2251799813685248`. Binary is `0x43200000_00000000`.</summary>
        public const long DoubleBit_2Pow51 = 0x43200000_00000000; // BitConverter.DoubleToInt64Bits(Math.Pow(2, 51)).ToString("X")
        /// <summary>DoubleBit - `(double)0x0010000000000000 = pow(2, 52) = 4503599627370496`. Binary is `0x43300000_00000000`.</summary>
        public const long DoubleBit_2Pow52 = 0x43300000_00000000; // BitConverter.DoubleToInt64Bits(Math.Pow(2, 52)).ToString("X")
        /// <summary>DoubleBit - `(double)0x0018000000000000 = pow(2, 52) + pow(2, 51) = 1.5*pow(2, 52) = 6755399441055744`. Binary is `0x43380000_00000000L`.</summary>
        public const long DoubleBit_2Pow52_2Pow51 = 0x43380000_00000000L; // BitConverter.DoubleToInt64Bits(1.5*Math.Pow(2, 52)).ToString("X")

        /// <summary>DoubleBit - Truncate - expMinuend.`((long)Double_ExponentBias * 2 + Double_ExponentShift) &lt;&lt; Double_ExponentShift = ((long)1023*2 + 52)&lt;&lt;52 = 0x8320000000000000 = -8998192055486251008`. `BitConverter.Int64BitsToDouble(-8998192055486251008) = -1.252605225005608E-293`, `BitConverter.DoubleToInt64Bits(-1.252605225005608E-293).ToString("X") = "8320000000000000"`.</summary>
        /// <remarks>If valueExpData is `(1023 + e)&lt;&lt;52`, `expMinuend-valueExpData` exponent field will be `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`</remarks>
        public const long DoubleBit_Truncate_expMinuend = ((long)Double_ExponentBias * 2 + Double_ExponentShift) << Double_ExponentShift;

        // -- DoubleVal: Value of Double --
        // /// <summary>DoubleVal - Sign mask (符号掩码). Binary is `0x8000000000000000L`.</summary>
        // [Obsolete("When JIT compile optimization, sometimes `-0` is treated as `0`, which may cause incorrect result. Therefore, this constant is removed (JIT编译优化时, 有时会将`-0`当作`0`, 造成结果不对的问题. 故取消此常数).")]
        // public const double DoubleVal_SignMask = -0.0; // double.NegativeZero
        /// <summary>DoubleVal - Exponent mask (指数掩码). Binary is `0x7FF0000000000000L`.</summary>
        public const double DoubleVal_ExponentMask = double.PositiveInfinity;
        /// <summary>DoubleVal - Mantissa mask (尾数掩码). Binary is `0x000FFFFFFFFFFFFFL`.</summary>
        public const double DoubleVal_MantissaMask = 2.2250738585072009E-308; // BitConverter.Int64BitsToDouble(0x000FFFFFFFFFFFFFL)
        // /// <summary>DoubleVal - Non-sign mask (非符号掩码). Binary is `0x7FFFFFFFFFFFFFFFL`.</summary>
        // public const double DoubleVal_NonSignMask = double.NaN; // The `7FFFFFFFFFFFFFFF` can't be equal to `BitConverter.DoubleToInt64Bits(double.NaN).ToString("X")` .
        /// <summary>DoubleVal - Non-exponent mask (非指数掩码). Binary is `0x800FFFFFFFFFFFFFL`.</summary>
        public const double DoubleVal_NonExponentMask = -2.2250738585072009E-308; // BitConverter.Int64BitsToDouble(unchecked((long)0x800FFFFFFFFFFFFFUL))
        /// <summary>DoubleVal - Non-mantissa mask (非尾数掩码). Binary is `0xFFF0000000000000L`.</summary>
        public const double DoubleVal_NonMantissaMask = double.NegativeInfinity;

        /// <summary>DoubleVal - `(double)0x0008000000000000 = pow(2, 51) = 2251799813685248`. Binary is `0x43200000_00000000`.</summary>
        public const double DoubleVal_2Pow51 = 0x0008000000000000L;
        /// <summary>DoubleVal - `(double)0x0010000000000000 = pow(2, 52) = 4503599627370496`. Binary is `0x43300000_00000000`.</summary>
        public const double DoubleVal_2Pow52 = 0x0010000000000000L;
        /// <summary>DoubleVal - `(double)0x0018000000000000 = pow(2, 52) + pow(2, 51) = 1.5*pow(2, 52) = 6755399441055744`. Binary is `0x43380000_00000000L`.</summary>
        public const double DoubleVal_2Pow52_2Pow51 = 0x0018000000000000L;

        /// <summary>DoubleVal - Truncate - expMinuend.`((long)Double_ExponentBias * 2 + Double_ExponentShift) &lt;&lt; Double_ExponentShift = ((long)1023*2 + 52)&lt;&lt;52 = 0x8320000000000000 = -8998192055486251008`. `BitConverter.Int64BitsToDouble(-8998192055486251008) = -1.252605225005608E-293`, `BitConverter.DoubleToInt64Bits(-1.252605225005608E-293).ToString("X") = "8320000000000000"`.</summary>
        /// <remarks>If valueExpData is `(1023 + e)&lt;&lt;52`, `expMinuend-valueExpData` exponent field will be `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`</remarks>
        public const double DoubleVal_Truncate_expMinuend = -1.252605225005608E-293;

    }
}
