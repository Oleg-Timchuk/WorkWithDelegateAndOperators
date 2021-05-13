using System;
using System.IO;
using System.Collections.Generic;

namespace Task_10
{
    class Program
    {
        public static void SpecialFunction1(string message, MyComplexBase myObj)
        {
            Console.WriteLine($"1. {message}: {myObj.Re} + {myObj.Im}*i");
        }

        public static void SpecialFunction2(string message, MyComplexBase myObj)
        {
            Console.WriteLine($"2. {message}: {myObj.Re} + {myObj.Im}*i");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            MyComplexBase v6 = new MyComplexBase(5, 7);

            Console.WriteLine(v6.ToString());

            int real, img;

            MyComplexBase v7 = new MyComplexChild();
            ((MyComplexChild)v7).InputFromTerminal(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), out real, out img);

            v7.Re = real;
            v7.Im = img;

            Console.WriteLine(v7.ToString());

            MyComplexBase v8 = new MyComplexChild();

            v8.Re = ((MyComplexChild)v8).InputFromFile("Re");
            v8.Im = ((MyComplexChild)v8).InputFromFile("Im");


            Console.WriteLine(v8.ToString());
        }
    }   
}
