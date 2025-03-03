using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Praktikum10._5._1
{
    public class Calculate : ISum, IError
    {
        ILogger Logger { get; }

        public Calculate (ILogger logger)
        {
            Logger = logger;
        }

        public int Sum(int a, int b)
        {
            Console.WriteLine();
            Logger.Event("Результат сложения двух чисел равен: ");
            return a + b;
        }

        public void MessageAboutError()
        {
            Logger.Error("Введено некорректное значение!");
            Console.WriteLine();
        }
    }
}
