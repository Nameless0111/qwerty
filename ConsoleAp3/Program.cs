double b = 0;
int d = 0;
double z;
double e = 0;
double c = 0;
double q = 0;
int k = 0;
int x = 0;
double g = 0;
int t = 0;
while (t != 1)
{
    c = 0;
    Console.WriteLine("Выберите необходимую программу:");
    Console.WriteLine("1. Игра \"Угадай число\"");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Выйти из меню");
    while (c != 1)
    {
        try
        {
            string a = Console.ReadLine();
            b = Convert.ToDouble(a);
            if (b < 1 || b > 4)
            {
                c = 0;
                Console.WriteLine("Введите корректное значение!");
            }
            else
            {
                c = 1;
            }
        }

        catch
        {
            Console.WriteLine("Введите корректное значение!");
            c = 0;
        }
    }
    c = 0;
    z = b;
    switch (z)
    {
        case 1:
            Console.WriteLine("Угадай число от 1 до 100!");
            Random random = new Random();
            int p = random.Next(0, 100);
            e = p;
            while (q != p)
            {
                c = 0;
                while (c != 1)
                {
                    try
                    {
                        string f = Console.ReadLine();
                        q = Convert.ToDouble(f);
                        if (q < 1 || q > 100)
                        {
                            c = 0;
                            Console.WriteLine("Введите корректное значение!");
                        }
                        else
                        {
                            c = 1;
                            if (q != p)
                            {
                                if (e > q)
                                {
                                    Console.WriteLine("Попробуй больше");
                                }
                                else
                                {
                                    Console.WriteLine("Попробуй меньше");
                                }
                            }
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Введите корректное значение!");
                        c = 0;
                    }
                }
            }

            Console.WriteLine("Молодец!Угадал!");
            break;
        case 2:
            int[,] array = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0,3} ",array[i, j]);
                }
                Console.WriteLine();
            }
            break;
        case 3:
            while (c != 1)
            {
                try
                {
                    Console.WriteLine("Введите желаемое число!");
                    string a = Console.ReadLine();
                    k = Convert.ToInt32(a);
                    c = 1;
                }

                catch
                {
                    Console.WriteLine("Введите корректное значение!");
                    c = 0;
                }
            }
            for (int W = k; W > 0; W--)
            {
                e = k / W;
                x = W;
                if (k % x == 0)
                {
                    Console.WriteLine(e);
                }
            }

            break;
        case 4:
            t = 1;
            Console.WriteLine("Спасибо, что выюрали эту программцу!");
            break;

    }
}