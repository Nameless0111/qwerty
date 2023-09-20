

using System;
int q;
do
{
    Console.WriteLine("Уважаемый пользователь, при вводе символов не являющихся цифрами, а также знаками (+ - ,) , всю ответственность за проиисходящие далее события вы берёте на себя!");
    Console.WriteLine("Выберите необходимую операцию:");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    Console.WriteLine("Введите номер желаемой операции:");
    int z = int.Parse(Console.ReadLine());
    q = z;

    do
    {
        switch (z)
        {
            case 1:
                Console.WriteLine("Введите желаемые значения:");
                string c1 = Console.ReadLine();
                string c2 = Console.ReadLine();
                double e1 = Convert.ToDouble(c1);
                double e2 = Convert.ToDouble(c2);
                double e = e1 + e2;
                Console.WriteLine("Результат операции:" + e);
                break;
            case 2:
                Console.WriteLine("Введите желаемые значения:");
                string c3 = Console.ReadLine();
                string c4 = Console.ReadLine();
                double e3 = Convert.ToDouble(c3);
                double e4 = Convert.ToDouble(c4);
                double ea = e4 - e3;
                Console.WriteLine("Результат операции:" + ea);
                break;
            case 3:
                Console.WriteLine("Введите желаемые значения:");
                string c5 = Console.ReadLine();
                string c6 = Console.ReadLine();
                double e5 = Convert.ToDouble(c5);
                double e6 = Convert.ToDouble(c6);
                double eb = e5 * e6;
                Console.WriteLine("Результат операции:" + eb);
                break;
            case 4:
                Console.WriteLine("Введите желаемые значения:");
                string c7 = Console.ReadLine();
                string c8 = Console.ReadLine();
                double e7 = Convert.ToDouble(c7);
                double e8 = Convert.ToDouble(c8);
                if (e8 == 0)
                {
                    Console.WriteLine("Делить на 0 запрещено");
                    break;
                }
                double eс = e7 / e8;
                Console.WriteLine("Результат операции:" + eс);
                break;
            case 5:
                Console.WriteLine("Введите желаемое значение:");
                string c9 = Console.ReadLine();
                Console.WriteLine("Введите желаемую степень N:");
                string c10 = Console.ReadLine();
                double e9 = Convert.ToDouble(c9);
                double e10 = Convert.ToDouble(c10);
                double ed = Math.Pow(e9, e10);
                Console.WriteLine("Результат операции:" + ed);
                break;
            case 6:
                Console.WriteLine("Введите желаемое значение:");
                string c11 = Console.ReadLine();
                double e11 = Convert.ToDouble(c11);
                double ee = Math.Sqrt(e11);
                Console.WriteLine("Результат операции:" + ee);
                break;
            case 7:
                Console.WriteLine("Введите желаемое значение:");
                string c12 = Console.ReadLine();
                double e12 = Convert.ToDouble(c12);
                double ef = e12 / 100;
                Console.WriteLine("Результат операции:" + ef);
                break;
            case 8:
                Console.WriteLine("Введите желаемое значение:");
                string c13 = Console.ReadLine();
                double e13 = Convert.ToDouble(c13);
                for (double i = e13; i > 1; i--)
                {
                    e13 = e13 * (i - 1);
                }
                if (e13 >= 0)
                {
                    double eg = e13;
                    Console.WriteLine("Результат операции:" + eg);
                }
                break;
        }
        break;
    } while ( z != 9);
    
} while (q != 9);
Console.WriteLine("Спасибо, что выбрали эту программу!");