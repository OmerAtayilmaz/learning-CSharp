using System;

namespace TypeConversion
{
    internal class TypeConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Conversion");
            //implicit type casting: no need to do anything for conversion
            int intNumber = 20;
            double doubleNum = intNumber;
            Console.WriteLine(intNumber);
            Console.WriteLine(doubleNum);
            
            //explicit type casting
            double dobNum = 4.75;
            int intVal = (int)dobNum;
            Console.WriteLine(intVal);
            
            /*
             * Casting Methods
             * Convert.ToBoolean(val)
             * Convert.ToByte(val)
             * Convert.ToChar(val)
             * Convert.ToDecimal(val)
             * Convert.ToDouble(val)
             * Convert.ToInt32/16/64(val)
             * Convert.ToSingle(val)
             * Convert.ToString(val)
             * Convert.ToType(val)
             * Convert.ToDatime(val)
             */
            Console.WriteLine("Before: {0} After:{1}",dobNum.ToString(),intVal.ToString());
        }
    }
}