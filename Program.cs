using System;

namespace ConsoleApp6_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Father.Sum(10,8));//متدی در کلاس پدر برای ویژگی جمع

            Console.WriteLine(Mother.Minus(10,8));//متدی درکلاس مادر برای ویژگی منها
            Console.WriteLine(Mother.Sum(10,8));//متدی در کلاس مادر برای ویژگی جمع که از کلاس پدر به ارث برده
           
            Console.WriteLine(Kid.Multiple(10,8));//متدی درکلاس بچه برای ویژگی ضرب
            Console.WriteLine(Kid.Sum(10,8));//متدی در کلاس بچه برای ویژگی جمع که از کلاس مادری به ارث برده که  خود کلاس مادر از کلاس پدر به ارث برده این ویژگی را 
            Console.WriteLine(Kid.Minus(10,8)); //متدی در کلاس بچه برای ویژگی منها که از کلاس مادر به ارث برده

            

        }
    }
}
