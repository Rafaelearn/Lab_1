using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_from_pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("S1.1");
            Console.Write("Введите число: ");
            double number_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число a с точностью до сотых - {0}", Math.Round(number_1, 2));

            Console.WriteLine("\nS1.2");
            Console.WriteLine("Число e с точностью 10 знаков после запятой - {0}", Math.Round(Math.E, 10));

            Console.WriteLine("\nS1.3");
            Console.Write("Введите число: ");
            double number_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели число: {0}", number_2);

            Console.WriteLine("\nS1.4");
            Console.Write("Введите число: ");
            double number_3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} — вот какое число Вы ввели", number_3);

            Console.WriteLine("\nS1.5");
            Console.WriteLine("{0} {1}", 1.13, 49);

            Console.WriteLine("\nS1.6");
            Console.WriteLine("{0}  {1}", 7.15, 100);

            Console.WriteLine("\nS1.7");
            Console.WriteLine("{0}  {1}  {2}", random.Next(), random.Next(), random.Next());

            Console.WriteLine("\nS1.8");
            Console.WriteLine("{0} {1} {2} {3}", random.Next(), random.Next(), random.Next(), random.Next());

            Console.WriteLine("\nS1.9");
            Console.WriteLine("50\n10");

            Console.WriteLine("\nS1.10");
            Console.WriteLine("5\n10\n21");

            Console.WriteLine("\nS1.11");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", random.Next(), random.Next(), random.Next(), random.Next());

            Console.WriteLine("\nS1.12");
            Console.WriteLine("5 10\n7 см");

            Console.WriteLine("\nS1.13");
            Console.WriteLine("2 кг\n13 17");


            Console.WriteLine("\n\nS2.1");
            Console.Write("a)Введите значение переменной x: ");
            double inputx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y=7x2+3x+6 => y={0}", 7 * Math.Pow(inputx, 2) + 3 * inputx + 6);
            Console.Write("b)Введите значение переменной a: ");
            double inputa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x=12a2+7a+12 => x={0}", 12 * Math.Pow(inputa, 2) + 7 * inputa + 12);

            Console.WriteLine("\nS2.2");
            Console.Write("Введите значение стороны квадрата: ");
            double side_square = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь квадрата =  {0}", side_square * side_square);

            Console.WriteLine("\nS2.3");
            Console.Write("Введите значение радиуса окружности: ");
            double radius_circle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Диаметр окружности =  {0}", radius_circle * 2);

            Console.WriteLine("\nS2.4");
            Console.Write("Введите значение высоты над землей в метрах: ");
            double height_gr = Convert.ToDouble(Console.ReadLine());
            int radius_eath = 6350000;
            Console.WriteLine("Считая, что Земля — идеальная сфера с радиусом R=6350 км. Расстояние до линии горизонта: {0} метров",
                Math.Sqrt(2 * radius_eath * height_gr + height_gr * height_gr));

            Console.WriteLine("\nS2.5");
            Console.Write("Введите значение ребра куба: ");
            double cube_edge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объем куба = {0}\nПлощадь боковой поверхности = {1}",
                Math.Pow(cube_edge, 3), Math.Pow(cube_edge, 2));

            Console.WriteLine("\nS2.6");
            Console.Write("Введите значение радиуса окружности: ");
            double radius_circle_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности = {0}\nПлощадь круга = {1}", 2 * Math.PI * radius_circle_2,
                Math.PI * radius_circle_2 * radius_circle_2);

            Console.WriteLine("\nS2.7");
            Console.Write("Введите 1-ое число: ");
            double number_4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            double number_5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Их среденее арифимитическое = {0};\nИх среденее геометрическое = {1};",
                (number_4 + number_5) / 2, Math.Sqrt(number_4 * number_5));

            Console.WriteLine("\nS2.8");
            Console.Write("Введите массу тела в кг: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите объем тела в м3: ");
            double volume = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Плотность тела = {0} кг/м3", weight / volume);

            Console.WriteLine("\nS2.9");
            Console.Write("Введите количество жителей в государстве: ");
            int number_citizens = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите площадь государства в км2: ");
            double state_area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Плотность населения в твоем государстве состоляет {0} человек на км2",
                number_citizens / state_area);

            Console.WriteLine("\nS2.10");
            Console.WriteLine("Введите коэффициенты линейного уравнения ax+b=0 (a ≠ 0).");
            Console.Write("а = ");
            double coefficient_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double coefficient_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x = {0}", -(coefficient_b / coefficient_a));

            Console.WriteLine("\nS2.11");
            Console.WriteLine("Введите катеты прямоугольного треугольника.");
            Console.Write("Введите 1-ый катет: ");
            double leg_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ой катет: ");
            double leg_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Гипотенуза = {0}", Math.Sqrt(leg_2 * leg_2 + leg_1 * leg_1));

            Console.WriteLine("\nS2.12");
            Console.WriteLine("Введите внешний и внутренний радиусы кольца.");
            Console.Write("Введите внешний радиус кольца: ");
            double radius_externel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите внутренний радиус кольца: ");
            double radius_internel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь кольца = {0}",
                Math.PI * (radius_externel * radius_externel - radius_internel * radius_internel));

            Console.WriteLine("\nS2.13");
            Console.WriteLine("Введите катеты прямоугольного треугольника.");
            Console.Write("Введите 1-ый катет: ");
            double leg_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ой катет: ");
            double leg_4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь прямоугольного треугольники = {0}", leg_4 * leg_3 / 2);

            Console.WriteLine("\nS2.13А");
            Console.Write("1-ое число: ");
            double number_6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-ое число: ");
            double number_7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Среднее арифимитическое модулей этих чисел = {0};\nСреднее геометрическое модулей этих чисел = {1}",
                (Math.Abs(number_6) + Math.Abs(number_7)) / 2, Math.Sqrt(Math.Abs(number_6) * Math.Abs(number_7)));

            Console.WriteLine("\nS2.14");
            Console.Write("Введите 1-ое основание трапеции: ");
            double base_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ое основание трапеции: ");
            double base_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту трапеции: ");
            double height_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь равнобедренной трапеции: {0}",
                height_1 * (base_1 + base_2) / 2);

            Console.WriteLine("\nS2.15");
            Console.Write("Число a: ");
            double number_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число b: ");
            double number_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a + b = {0}", number_a + number_b);
            Console.WriteLine("a - b = {0}", number_a - number_b);
            Console.WriteLine("a * b = {0}", number_a * number_b);
            Console.WriteLine("a / b = {0}", number_a / number_b);

            Console.WriteLine("\nS2.16");
            Console.Write("Введите длину параллепипеда: ");
            double side_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину параллепипеда: ");
            double side_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту параллепипеда: ");
            double side_3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объем параллепипеда: {0}", side_3 * side_2 * side_1);
            Console.WriteLine("Площадь боковой поверхности параллепипеда: {0}",
                (side_1 * side_2 + side_1 * side_3 + side_2 * side_3) * 2);

            Console.WriteLine("\nS2.17");
            Console.WriteLine("Введите координаты 2-x точек A(x1, y1) и B(x2, y2).");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("d(A,B) = {0}",
                Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine("\nS2.18");
            Console.Write("Введите 1-ое основание трапеции: ");
            double base_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ое основание трапеции: ");
            double base_4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту трапеции: ");
            double height_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь равнобедренной трапеции: {0}",
                base_4 + base_3 +
                2 * (Math.Pow(Math.Pow((base_4 - base_3) / 2, 2) + Math.Pow(height_2, 2), 2)));

            Console.WriteLine("\nS2.19");
            Console.Write("Введите 1-ое основание трапеции: ");
            double base_5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ое основание трапеции: ");
            double base_6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите угол в градусах при большем основании: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь равнобедренной трапеции: {0}",
                Math.Abs(base_6 * base_6 - base_5 * base_5) * Math.Tan(angle * Math.PI / 180) / 4);

            Console.WriteLine("\nS2.20");
            Console.WriteLine("Введите координаты вершин треугольника A(x3, y3), B(x4, y4), С(x5, y5).");
            Console.Write("x3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x4 = ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y4 = ");
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x5 = ");
            double x5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y5 = ");
            double y5 = Convert.ToDouble(Console.ReadLine());
            double ab = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            double ac = Math.Sqrt(Math.Pow(x5 - x3, 2) + Math.Pow(y5 - y3, 2));
            double cb = Math.Sqrt(Math.Pow(x5 - x4, 2) + Math.Pow(y5 - y4, 2));
            double perimeter = ab + ac + cb;
            Console.WriteLine("Периметр треугольника: {0}", perimeter);
            Console.WriteLine("Площадь треугольника: {0}",
                Math.Sqrt((perimeter / 2) * (perimeter / 2 - ac) * (perimeter / 2 - ab) * (perimeter / 2 - cb)));

            Console.WriteLine("\nS2.21");
            Console.WriteLine("Введите координаты вершин выпуклого четырехугольника E(x6, y6), F(x7, y7), G(x8, y8), H(x9, y9).");
            Console.Write("x6 = ");
            double x6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y6 = ");
            double y6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x7 = ");
            double x7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y7 = ");
            double y7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x8 = ");
            double x8 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y8 = ");
            double y8 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x9 = ");
            double x9 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y9 = ");
            double y9 = Convert.ToDouble(Console.ReadLine());
            double ef = Math.Sqrt(Math.Pow(x6 - x7, 2) + Math.Pow(y6 - y7, 2));
            double eg = Math.Sqrt(Math.Pow(x6 - x8, 2) + Math.Pow(y6 - y8, 2));
            double eh = Math.Sqrt(Math.Pow(x6 - x9, 2) + Math.Pow(y6 - y9, 2));
            double gf = Math.Sqrt(Math.Pow(x8 - x7, 2) + Math.Pow(y8 - y7, 2));
            double gh = Math.Sqrt(Math.Pow(x8 - x9, 2) + Math.Pow(y8 - y9, 2));
            double s_perimetr_efg = (ef + gf + eg) / 2;
            double s_perimetr_ehg = (eh + gh + eg) / 2;
            Console.WriteLine("Площадь выпуклого четырехугольника: {0}",
                Math.Sqrt((s_perimetr_efg / 2) * (s_perimetr_efg / 2 - ef) * (s_perimetr_efg / 2 - gf) * (s_perimetr_efg / 2 - eg)) +
                Math.Sqrt((s_perimetr_ehg / 2) * (s_perimetr_ehg / 2 - eh) * (s_perimetr_ehg / 2 - gh) * (s_perimetr_ehg / 2 - eg)));

            Console.WriteLine("\nS2.22");
            int candies_price = random.Next(100, 200);
            int biscuits_price = random.Next(100, 200);
            int apples_price = random.Next(50, 100);
            Console.WriteLine("Стоимость конфет - {0}$ за киллограм\nСтоимость печенья - {1}$ за киллограм\nСтоимость яблок - {2}$ за киллограм\n",
                candies_price, biscuits_price, apples_price);
            Console.Write("Введите массу конфет в кг: ");
            double candies_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите массу печенья в кг: ");
            double biscuits_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите массу яблок в кг: ");
            double apples_weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость вашей покупки: {0}",
                candies_price * candies_weight + biscuits_price * biscuits_weight + apples_price * apples_weight);

            Console.WriteLine("\nS2.23");
            int keyboard_price = random.Next(100, 200);
            int monitor_price = random.Next(400, 500);
            int mouse_price = random.Next(50, 100);
            int sysunit_price = random.Next(1500, 3000);
            Console.WriteLine("Прайс-лист:\n  Клавиатура = {0}\n  Монитор = {1}\n  Мышь = {2}\n  Системный блок = {3}\n 3 компьютера = {4} ",
                keyboard_price, monitor_price, mouse_price, sysunit_price, 3 * (keyboard_price + mouse_price + mouse_price + sysunit_price));
            Console.Write("Введите количество компьютеров которое вы хотите купить: ");
            int num_computer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость вашей покупки: {0}",
                (keyboard_price + mouse_price + mouse_price + sysunit_price) * num_computer);

            Console.WriteLine("\nS2.24");
            Console.Write("Введите возраст Тани: ");
            int age_tanya = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите возраст Мити: ");
            int age_mitya = Convert.ToInt32(Console.ReadLine());
            float average = (age_mitya + age_tanya) / 2;
            Console.WriteLine("Средний возраст Мити и Тани: {0}", average);
            Console.WriteLine("Возраст Мити отличается от среднего на {0} лет(год)", Math.Abs(average - age_mitya));
            Console.WriteLine("Возраст Тани отличается от среднего на {0} лет(год)", Math.Abs(average - age_tanya));

            Console.WriteLine("\nS2.25\nДва автомобиля едут навстречу друг другу с постоянными скоростями.");
            Console.Write("Введите скорость 1-ого автомобиля в км/ч: ");
            double speed_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость 2-ого автомобиля в км/ч: ");
            double speed_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояния между автомобилями в км: ");
            double distance_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Автомобили встретятся через {0} час(а)", distance_1 / (speed_1 + speed_2));

            Console.WriteLine("\nS2.26\nДва автомобиля едут навстречу друг другу с постоянными скоростями. Первый автомобиль быстрее второго.");
            Console.Write("Введите скорость 1-ого автомобиля в км/ч: ");
            double speed_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость 2-ого автомобиля в км/ч: ");
            double speed_4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояния, на которое первый автомобиль опрередил второй в км: ");
            double distance_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Через 30 минут после того, как первый автомобиль опередил второй на {0}км, расстояние между ними будет {1}км",
                distance_2, distance_2 + 0.5 * (speed_3 - speed_4));

            Console.WriteLine("\nS2.27");
            double temperature = random.Next(1000) - 273.15;
            Console.WriteLine("Значение температуры t по шкале Цельсия: {0}", temperature);
            Console.WriteLine("t  = {0} фаренгейтов", temperature * 1.8 + 32);
            Console.WriteLine("t  = {0} кельвинов", temperature + 273.15);

            Console.WriteLine("\nS2.28");
            Console.WriteLine("450 градусов по Фаренгейту есть {0} градусов по шкале Цельсия",
                (450 - 32) / 1.8);



            Console.WriteLine("\n\nS3.1");
            Console.Write("Введите значение a: ");
            double a_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b_1 = Convert.ToDouble(Console.ReadLine());
            double box_1 = 0;
            box_1 = a_1;
            a_1 = b_1;
            b_1 = box_1;
            Console.WriteLine("После обмена значениями: a = {0}; b = {1}.", a_1, b_1);

            Console.WriteLine("\nS3.2\nа) b присвоить значение c, а присвоить значение b, с присвоить значение а;\nб) b присвоить значение а, с присвоить значение b, а присвоить значение с.");
            Console.Write("Введите значение a: ");
            double a_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c_2 = Convert.ToDouble(Console.ReadLine());
            double box_2 = 0;
            box_2 = b_2;
            b_2 = c_2;
            c_2 = a_2;
            a_2 = box_2;
            Console.WriteLine("После обмена значениями по правилам пункта (a): a = {0}; b = {1}; c = {2}.", a_2, b_2, c_2);
            box_2 = a_2;
            a_2 = c_2;
            c_2 = b_2;
            b_2 = box_2;
            Console.WriteLine("После обмена значениями по правилам пункта (б): a = {0}; b = {1}; c = {2}.", a_2, b_2, c_2);

            Console.WriteLine("\nS3.3");
            Console.WriteLine("Введите значение а: ");
            double a_3 = Convert.ToDouble(Console.ReadLine());

            double a2_3 = a_3 * a_3;
            double a4_3 = a2_3 * a2_3;


            double a6_3 = a2_3 * a2_3 * a2_3; // + a2_3 = a_3 * a_3(еще одна операция)

            double a7_3 = a6_3 * a_3;// a6_3 получаем за три опреации из (б)

            double a8_3 = a4_3 * a4_3;// a4_3 получаем за две опреации из (а)

            double a9_3 = a8_3 * a_3; // a8_3 получаем за три опреации из (г)

            double a10_3 = a8_3 * a2_3; // a8_3  и а2_3 получаем за три опреации из (а) и (г)
            Console.WriteLine("a4 = {0}\na6 = {1}\na7 = {2}\na8 = {3}\na9 = {4}\na10 = {5}",
                a4_3, a6_3, a7_3, a8_3, a9_3, a10_3);


            Console.WriteLine("\nS3.4");
            Console.WriteLine("Введите значение а: ");
            double a_4 = Convert.ToDouble(Console.ReadLine());

            double a2_4 = a_4 * a_4;
            double a3_4 = a2_4 * a_4;
            double a5_4 = a3_4 * a2_4;
            double a10_4 = a5_4 * a5_4;

            // a2_4 = a_4 * a_4;
            double a4_4 = a2_4 * a2_4;
            double a8_4 = a4_4 * a4_4;
            double a16_4 = a8_4 * a8_4;
            double a20_4 = a16_4 * a4_4;

            // a10 и а3 получаем за четыре операции из (а)
            double a13_4 = a10_4 * a3_4;


            /*
            a2_4 = a_4 * a_4;
            a4_4 = a2_4 * a2_4;
            a5_4 = a4_4 * a_4;
            a10_4 = a5_4 * a5_4;
            */
            double a19_4 = a10_4 * a5_4 * a4_4; // 

            /*
            a2_4 = a_4 * a_4;
            a4_4 = a2_4 * a2_4;
            a5_4 = a4_4 * a_4;
            a10_4 = a5_4 * a5_4;
            */
            double a17_4 = a10_4 * a5_4 * a2_4;

            /*
            a2_4 = a_4 * a_4;
            a4_4 = a2_4 * a2_4;
            */
            double a12_4 = (a4_4 * a4_4) * a4_4;
            double a28_4 = a12_4 * a12_4 * a4_4;

            Console.WriteLine("a3 = {0} a10 = {1}\na4 = {2} a20 = {3}\na5 = {4} a13 = {5}\n" +
                " a5 = {6} a19 = {7}\n a2 = {8} a5 = {9} a17 = {10}\n a4 = {11} a12 = {12} a28 = {13}",
             a3_4, a10_4, a4_4, a20_4, a5_4, a13_4, a5_4, a19_4, a2_4, a5_4, a17_4, a4_4, a12_4, a28_4);

            Console.WriteLine("\nS3.5");
            int a_5 = 10;
            int a2_5 = a_5 * a_5;
            int a4_5 = a2_5 * a2_5;
            long a8_5 = a4_5 * a4_5;
            long a10_5 = a8_5 * a2_5;
            Console.WriteLine("10 в степени 10 можно получить по моему алгоритму за 4 операции умножения" +
                " при вещественном числе a = 10 (см. пункт (а) задания S3.4).\na10 = {0} ", a10_5);

            Console.ReadKey();

        }
    }
}
