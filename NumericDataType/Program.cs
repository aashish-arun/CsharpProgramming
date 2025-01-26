using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring and initializing on different lines
            int Num; //Declaring a variable
            Num = 23; //Initializing a value to a variable
            Console.WriteLine(Num); //Output


            //Declaring and initializing on the same line
            int Num2 = 25;
            Console.WriteLine(Num2); //Output


            //Declaring and initializing on the same line with assigning a different value later on
            int Num3 = 25;
            Console.WriteLine(Num3); //Output
            Num3 = 45;
            Console.WriteLine(Num3); //Output



            //Numeric data type
            int IntNum = 15; //1. For integer numbers - initialize the variable as int and its value should be int32
            Console.WriteLine(IntNum); //Output

            Console.WriteLine(int.MaxValue); //Max value of int
            Console.WriteLine(int.MinValue); //Min value of int
            //Note: int variables can have values which are also negative.


            long LongNum = 97969551543523L; //2. For bigger integer numbers - initialize the variable as long and its value should be int64
            Console.WriteLine(LongNum); //Output

            Console.WriteLine(long.MaxValue); //Max value of long
            Console.WriteLine(long.MinValue); //Min value of long
            //Notes: long variables can have values which are also negative. Also the value for a long variable should end with an "L".


            float FloatNum = 5F; //3. For floating numbers - initialize the variable as float and its value should be single (i.e. float)
            Console.WriteLine(FloatNum); //Output

            Console.WriteLine(float.MaxValue); //Max value of float
            Console.WriteLine(float.MinValue); //Min value of float
            //Notes: float variables can have values which are also negative. Also the value for a float variable should end with an "F".


            double DoubleNum = -55.2D; //4. For bigger floating numbers - initialize the variable as double and its value should also be double
            Console.WriteLine(DoubleNum); //Output

            Console.WriteLine(double.MaxValue); //Max value of double
            Console.WriteLine(double.MinValue); //Min value of double
            //Notes: double variables can have values which are also negative. Also the value for a double variable should end with an "D".


            decimal DecimalNum = 55.5M; //5. For decimal numbers - initialize the variable as decimal and its value should also be decimal
            Console.WriteLine(DecimalNum);

            Console.WriteLine(decimal.MaxValue); //Max value of decimal
            Console.WriteLine(decimal.MinValue); //Min value of decimal
            //Notes: decimal variables can have values which are also negative. Also the value for a decimal variable should end with an "M"



            Console.ReadLine();
        }
    }
}
