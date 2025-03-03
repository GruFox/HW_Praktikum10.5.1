//Задание 1:
//Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел. Определите интерфейс для функции сложения числа и реализуйте его.
//Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.

//Задание 2:
//Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
//Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.

namespace HW_Praktikum10._5._1;

internal class Program
{
    static ILogger Logger { get; set; }
    static void Main(string[] args)
    {
        Logger = new Logger();

        while (true)
        {
            var calc = new Calculate(Logger);
            try
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Введите первое значение:");
                int firstValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе значение:");
                int secondValue = int.Parse(Console.ReadLine());                

                Console.WriteLine(calc.Sum(firstValue, secondValue));
                break;
            }
            catch (Exception ex)
            {
                calc.MessageAboutError();
            }
        }            
    }
}
