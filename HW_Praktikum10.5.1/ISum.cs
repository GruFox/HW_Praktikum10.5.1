using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Praktikum10._5._1
{
    public interface ISum
    {
        /// <summary>
        /// Суммирует два значения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Возвращает сумму двух значений</returns>
        int Sum(int a, int b);
    }
}
