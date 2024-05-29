using System;

namespace UnderstandingTypes
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type       | Bytes | Min Value                             | Max Value");
            Console.WriteLine("-----------|-------|---------------------------------------|---------------------------------------");
            
            PrintTypeInfo<sbyte>("sbyte");
            PrintTypeInfo<byte>("byte");
            PrintTypeInfo<short>("short");
            PrintTypeInfo<ushort>("ushort");
            PrintTypeInfo<int>("int");
            PrintTypeInfo<uint>("uint");
            PrintTypeInfo<long>("long");
            PrintTypeInfo<ulong>("ulong");
            PrintTypeInfo<float>("float");
            PrintTypeInfo<double>("double");
            PrintTypeInfo<decimal>("decimal");

            Console.ReadKey();
        }

        static void PrintTypeInfo<T>(string typeName) where T : struct
        {
            Console.WriteLine("{0,-10} | {1,5} | {2,37} | {3,37}",
                typeName,
                System.Runtime.InteropServices.Marshal.SizeOf(typeof(T)),
                GetMinValue<T>(),
                GetMaxValue<T>());
        }

        static string GetMinValue<T>() where T : struct
        {
            return typeof(T).IsPrimitive || typeof(T) == typeof(decimal)
                ? Convert.ToString(GetMinGenericValue<T>())
                : "N/A";
        }

        static string GetMaxValue<T>() where T : struct
        {
            return typeof(T).IsPrimitive || typeof(T) == typeof(decimal)
                ? Convert.ToString(GetMaxGenericValue<T>())
                : "N/A";
        }

        static object GetMinGenericValue<T>() where T : struct
        {
            return typeof(T) == typeof(sbyte) ? sbyte.MinValue :
                   typeof(T) == typeof(byte) ? byte.MinValue :
                   typeof(T) == typeof(short) ? short.MinValue :
                   typeof(T) == typeof(ushort) ? ushort.MinValue :
                   typeof(T) == typeof(int) ? int.MinValue :
                   typeof(T) == typeof(uint) ? uint.MinValue :
                   typeof(T) == typeof(long) ? long.MinValue :
                   typeof(T) == typeof(ulong) ? ulong.MinValue :
                   typeof(T) == typeof(float) ? float.MinValue :
                   typeof(T) == typeof(double) ? double.MinValue :
                   typeof(T) == typeof(decimal) ? decimal.MinValue :
                   throw new ArgumentException("Unsupported type");
        }

        static object GetMaxGenericValue<T>() where T : struct
        {
            return typeof(T) == typeof(sbyte) ? sbyte.MaxValue :
                   typeof(T) == typeof(byte) ? byte.MaxValue :
                   typeof(T) == typeof(short) ? short.MaxValue :
                   typeof(T) == typeof(ushort) ? ushort.MaxValue :
                   typeof(T) == typeof(int) ? int.MaxValue :
                   typeof(T) == typeof(uint) ? uint.MaxValue :
                   typeof(T) == typeof(long) ? long.MaxValue :
                   typeof(T) == typeof(ulong) ? ulong.MaxValue :
                   typeof(T) == typeof(float) ? float.MaxValue :
                   typeof(T) == typeof(double) ? double.MaxValue :
                   typeof(T) == typeof(decimal) ? decimal.MaxValue :
                   throw new ArgumentException("Unsupported type");
        }
    }
}
