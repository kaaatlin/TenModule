using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TenModule
{
    public class Input : Ilogger
    {
        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Event()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void Menu()
        {
            try
            {
                Event();
                Console.WriteLine("Введите 1-е число");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2-е число");
                int second = int.Parse(Console.ReadLine());
                Sum sum = new Sum();
                int result = sum.Calc(first, second);
                Console.WriteLine("Сумма: " + result);
            }
            catch (Exception e)
            {
                Error();
                Console.WriteLine(e.Message);
                Menu();
            }
        }
    }
}
