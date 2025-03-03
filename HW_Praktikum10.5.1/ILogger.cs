using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Praktikum10._5._1
{
    public interface ILogger
    {
        /// <summary>
        /// Печатает сообщение о событии
        /// </summary>
        /// <param name="message"></param>
        void Event(string message);

        /// <summary>
        /// Печатает сообщение об ошибке
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
    }
}
