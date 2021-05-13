using System;
using System.Collections.Generic;
using System.Text;

namespace Task_10
{
    class MyComplexBase
    {
        public delegate void SpecialOutput(string message, MyComplexBase myObj);

        public SpecialOutput mySetFuncOutput;

        public void AddDelegate(SpecialOutput b)
        {
            mySetFuncOutput += b;
        }

        public void MinucDelegate(SpecialOutput b)
        {
            mySetFuncOutput -= b;
        }

        public override string ToString()
        {
            mySetFuncOutput = Program.SpecialFunction1;
            mySetFuncOutput += Program.SpecialFunction2;

            mySetFuncOutput("8", this);

            Console.WriteLine("Delegate is working");

            return "Комп.число = " + Re + "+" + Im + "i \n";

        }

        private double re;

        public virtual double Re
        {
            get
                
            { 
                return re; 
            }

            set
                
            { 
                re = value; 
            }
        }

        private double im;

        public virtual double Im
        {
            get

            { 
                return im; 
            }

            set
                
            { 
                im = value;
            }
        }

        public MyComplexBase(double Re = 0, double Im = 0)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public static MyComplexBase operator /(MyComplexBase a, MyComplexBase b)
        {
            return new MyComplexBase { Re = a.Re * b.Re, Im = a.Im * b.Im };
        }

        public static MyComplexBase operator /(MyComplexBase a, double x)
        {
            return new MyComplexBase { Re = a.Re * x, Im = a.Im * x, };
        }
        public static MyComplexBase operator /(double x, MyComplexBase a)
        {
            return new MyComplexBase { Re = a.Re * x, Im = a.Im * x };
        }
        public static MyComplexBase operator /(int x, MyComplexBase a)
        {
            return new MyComplexBase { Re = a.Re * x, Im = a.Im * x };
        }
        public static MyComplexBase operator /(MyComplexBase a, int x)
        {
            return new MyComplexBase { Re = a.Re * x, Im = a.Im * x };
        }
        public static MyComplexBase operator -(MyComplexBase a)
        {
            return new MyComplexBase { Re = -a.Re, Im = -a.Im };
        }
    }
}
