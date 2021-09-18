using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 2.1");
            Console.Write("Как твое имя, друг: ");
            string name = Console.ReadLine();
            Console.WriteLine("Приветствую тебя, {0}!", name);

            Console.WriteLine("\nExercise 2.2");
            Console.WriteLine("Введите пожалуйста 2 целых числа.");
            Console.Write("Первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 != 0)
            {
                double quotient = Convert.ToDouble(number1) / number2;
                Console.WriteLine("{0} / {1} = {2}", number1, number2, quotient);
            }
            else
            {
                Console.WriteLine("Делить {0} на {1} невозможно!", number1, number2);
            }
            


            Console.WriteLine("\nHome exercise 2.1");
            Console.Write("Введите букву: ");
            char letter = Console.ReadKey().KeyChar;
            if (letter == 'z' || letter == 'я' || letter == 'Я' || letter == 'Z')
            {
                Console.WriteLine("\nСледующей буквой за введенной букой не существует");
            }
            else
            {
                letter = Convert.ToChar(Convert.ToInt16(letter) + 1);
                Console.WriteLine("\nСледующей буквой является - {0}", letter);
            }


            Console.WriteLine("\nHome exercise 2.2");
            Console.WriteLine("Введите вещественные коэффициенты уравнения.");
            Console.Write("Введите коэффициент a перед x2: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b перед x: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свободный член c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = 0;
            if (b * b < 4 * a * c)
            {
                discriminant = Math.Pow(4 * a * c - b * b, 0.5);
                Console.WriteLine("Корни уравнения:\n1) {0} + {1}i\n2) {0} - {1}i",
                    -b / (2 * a), Math.Sqrt(discriminant) / (2 * a));
            }
            else
            {
                discriminant = Math.Pow(b * b - 4 * a * c, 0.5);
                if (discriminant == 0)
                {
                    Console.WriteLine("Корень уравнения: {0}", -b / (2 * a));
                }
                else
                {
                    Console.WriteLine("Корни уравнения:\n1) {0}\n2) {1}",
                        (-b + Math.Sqrt(discriminant)) / (2 * a), (-b - Math.Sqrt(discriminant)) / (2 * a));
                }
            }

            Console.ReadKey();
        }
    }
    
}
