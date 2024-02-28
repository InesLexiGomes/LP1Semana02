using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sbyte:{sbyte.MaxValue};{sbyte.MinValue}");
            Console.WriteLine($"Short:{short.MaxValue};{short.MinValue}");
            Console.WriteLine($"Int:{int.MaxValue};{int.MinValue}");
            Console.WriteLine($"Long:{long.MaxValue};{long.MinValue}");
            Console.WriteLine($"Byte:{byte.MaxValue};{byte.MinValue}");
            Console.WriteLine($"UShort:{ushort.MaxValue};{ushort.MinValue}");
            Console.WriteLine($"UInt:{uint.MaxValue};{uint.MinValue}");
            Console.WriteLine($"ULong:{ulong.MaxValue};{ulong.MinValue}");
            Console.WriteLine($"Float:{float.MaxValue};{float.MinValue}");
            Console.WriteLine($"Double:{double.MaxValue};{double.MinValue}");
            Console.WriteLine($"Decimal:{decimal.MaxValue};{decimal.MinValue}");
        }
    }
}
