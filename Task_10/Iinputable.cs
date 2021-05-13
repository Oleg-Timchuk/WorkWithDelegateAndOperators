using System;
using System.Collections.Generic;
using System.Text;

namespace Task_10
{
    interface Iinputable
    {
        public void InputFromTerminal(int a, int b, out int real, out int img);

        public double InputFromFile(string path);

    }
}
