using System;


namespace HW2_1_Numeric_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type that you want to see\n" +
                "press 1 for SByte \n"+
                "press 2 for Short(INT16)\n" +
                "press 3 for Int(INT32)\n" +
                "press 4 for Long(INT64)\n" +
                "press 5 for Float(Single)\n" +
                "press 6 for Double\n" +
                "press 7 for Decimal\n" +
                "press 8 for Byte\n" +
                "press 9 for UShort(UInt16)\n" +
                "press 10 for UInt(UInt32)\n" +
                "press 11 for ULong(UInt64)\n" +
                "or press another number for all types\n");
            string caseSwitch = Console.ReadLine();
            
            switch (caseSwitch)
            {
                case "1":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(sbyte).ToString(), sbyte.MinValue, sbyte.MaxValue, default(sbyte));
                    break;

                case "2":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(short).ToString(), short.MinValue, short.MaxValue, default(short));
                    break;

                case "3":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(int).ToString(), int.MinValue, int.MaxValue, default(int));
                    break;

                case "4":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(long).ToString(), long.MinValue, long.MaxValue, default(long));
                    break;

                case "5":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(float).ToString(), float.MinValue, float.MaxValue, default(float));
                    break;

                case "6":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(double).ToString(), double.MinValue, double.MaxValue, default(double));
                    break;

                case "7":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(decimal).ToString(), decimal.MinValue, decimal.MaxValue, default(decimal));
                    break;

                case "8":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(byte).ToString(), byte.MinValue, byte.MaxValue, default(byte));
                    break;

                case "9":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(ushort).ToString(), ushort.MinValue, ushort.MaxValue, default(ushort));
                    break;

                case "10":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(uint).ToString(), uint.MinValue, uint.MaxValue, default(uint));
                    break;

                case "11":
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(ulong).ToString(), ulong.MinValue, ulong.MaxValue, default(ulong));
                    break;

               
                default:
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(sbyte).ToString(), sbyte.MinValue, sbyte.MaxValue, default(sbyte));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(short).ToString(), short.MinValue, short.MaxValue, default(short));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                       typeof(int).ToString(), int.MinValue, int.MaxValue, default(int));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(long).ToString(), long.MinValue, long.MaxValue, default(long));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                       typeof(float).ToString(), float.MinValue, float.MaxValue, default(float));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                       typeof(double).ToString(), double.MinValue, double.MaxValue, default(double));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(decimal).ToString(), decimal.MinValue, decimal.MaxValue, default(decimal));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                       typeof(byte).ToString(), byte.MinValue, byte.MaxValue, default(byte));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                       typeof(ushort).ToString(), ushort.MinValue, ushort.MaxValue, default(ushort));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                       typeof(uint).ToString(), uint.MinValue, uint.MaxValue, default(uint));
                    Console.WriteLine("Type = {0}, Min = {1}, Max={2}, default = {3};",
                        typeof(ulong).ToString(), ulong.MinValue, ulong.MaxValue, default(ulong));
                   
                    break;
            }
                                   
        System.Console.ReadKey();

        }

       }
}