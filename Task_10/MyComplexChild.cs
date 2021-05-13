using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task_10
{
    class MyComplexChild : MyComplexBase, Iinputable
    {
        public MyComplexChild(double Re = 0, double Im = 0)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public double InputFromFile(string path)
        {
            FileStream file2 = new FileStream("H:\\" + path + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader wr2 = new StreamReader(file2);

            double a = 0;
            while (true)
            {
                string temp1;
                temp1 = wr2.ReadLine();
                if (temp1 != null)
                {
                    a = Convert.ToInt32(temp1);
                }
                else
                {
                    break;
                }
            }
            wr2.Close();
            return a;    
        }

        public void InputFromTerminal(int a, int b, out int real, out int img)
        {
            real = a;
            img = b;
        }
        private double re;

        public override double Re
        {


            get { return re; }
            set
            {
                if (value <= 50 || 300 < value || value >= 700)
                    re = value;
                else
                {
                    re = 0;
                }
            }
        }

        private double im;

        public override double Im
        {
            
            get { return im; }
            set                                                     
            {
                if (80 <= value || value > 130 || 1500 <= value || value > 8000)
                    im = value;
                else
                {
                    im = 0;
                }
            }
        }

    }
}
