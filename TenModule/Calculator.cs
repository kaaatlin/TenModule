using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenModule
{
    public interface Calculator
    {
        int Calc(int a, int b);
    }

    public interface Ilogger
    {
        void Event();
        void Error();
    }
}
