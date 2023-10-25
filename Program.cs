


string[] dates = new string[]{
    "18.10.2023", "19.10.2023", "20.10.2023", "21.10.2023", "22.10.2023", "23.10.2023"};
int date = 3;
int position = 0;
int z = 1;
int d = 1;
int p = 0;
ConsoleKeyInfo key = Console.ReadKey();

int smena_dat(int date)
{
    p = 0;
    switch (z)
    {
        case 0:
            date--;
            if (date == -1)
            {
                date++;
            }
            break;
        case 1:
            date++;
            if (date == 6)
            {
                date--;
            }
            break;
    }
    return date;
}
void Datess(int date)
{
    string[] dates = new string[]
    {
    "18.10.2023", "19.10.2023", "20.10.2023", "21.10.2023", "22.10.2023", "23.10.2023"};
    if (date == 0)
    {
        Console.WriteLine(dates[0]);
        Console.SetCursorPosition(0, 1);

    }
    if (date == 1)
    {
        Console.WriteLine(dates[1]);
        Console.SetCursorPosition(0, 1);

    }
    else if (date == 2)
    {
        Console.WriteLine(dates[2]);
        Console.SetCursorPosition(0, 1);

    }
    else if (date == 3)
    {
        Console.WriteLine(dates[3]);
        if (p == 0)
        {
            Console.WriteLine("->1. Сходи погуляй с другом.");
            p++;
        }
        else
        {
            Console.WriteLine("  1. Сходи погуляй с другом.");
            position++; ;
        }
        Console.WriteLine("  2. Сходи в магазин.");
        Console.SetCursorPosition(0, 1);
    }
    else if (date == 4)
    {
        Console.WriteLine(dates[4]);
        Console.WriteLine("->1. Сделай практическую по Шарпу.");

        Console.SetCursorPosition(0, 1);
    }
    else if (date == 5)
    {
        Console.WriteLine(dates[5]);

        Console.WriteLine("->1. Ты хотел почитать.");
        Console.SetCursorPosition(0, 1);
    }

}
int w = 1;
void Description(int date)
{
    if (d == 1)
    {
            if (date == 3)
        {
            if (position == 1)
            {

                Console.WriteLine("  1.Сходи погуляй с другом.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Просто иди погуляй");
                Console.WriteLine("Дата: ");
                Console.WriteLine(dates[3]);
            }
            else if (position == 2)
            {
                Console.WriteLine("  2. Сходи в магазин.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("надо сделать дз");
                Console.WriteLine("Дата: ");
                Console.WriteLine(dates[3]);
            }
            else position = 2;
            d = 0;
        }
        else if (date == 4)
        {
            if (position == 1)
            {

                Console.WriteLine("  1. Сделай практическую по Шарпу.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Или получишь 2");
                Console.WriteLine("Дата: ");
                Console.WriteLine(dates[4]);
            }
            else position = 1;
            d = 0;
        }
        else if (date == 5)
        {
            if (position == 1)
            {

                Console.WriteLine("1.Ты хотел почитать.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Читать полезно.");
                Console.WriteLine(dates[5]);
            }
            else position = 1;
            d = 0;
        }
        else
        {
            Console.WriteLine("  На этот день нет заметок.");
            d = 0;
        }


    }
}
void strelochka(int w)
{
    if (w == 1)
    {
        position--;
        if (date != 3)
        {
            position = 1;
            if (date != 5 && date != 4)
            {
                position = 1;
            }
        }
        if (position <= 0)
        {
            position = 1;
        }
    }
    else if (w == 2)
    {
        position++;
        if (date != 3 && date != 4)
        {
            position = 1;
            if (date != 5)
            {
                position = 1;
            }
        }
        if (position == 3)
        {
            position--;
        }
    }
    else if (w == 0)
    {
        position = position;
    }
    Console.SetCursorPosition(0, position);
    if (date != 0 && date != 1 && date != 2)
    {
        Console.WriteLine("->");
    }
}
ConsoleKeyInfo key1;
do
{
    key1 = Console.ReadKey(true); switch (key1.Key)
    {
        case ConsoleKey.LeftArrow:
            z = 0;

            Console.Clear();
            date = smena_dat(date);
            Datess(date);
            break;
        case ConsoleKey.RightArrow:
            z = 1;
            Console.Clear();
            date = smena_dat(date);
            Datess(date);
            break;
        case ConsoleKey.UpArrow:
            w = 1;
            Console.Clear();
            Datess(date);
            strelochka(w);
            break;
        case ConsoleKey.DownArrow:
            w = 2;
            Console.Clear();
            Datess(date);
            strelochka(w);
            break;
        case ConsoleKey.Enter:
            if (d == 1)
            {
                Console.Clear();
                Description(date);
                break;
            }
            else if (d == 0)
            {
                Console.Clear();
                Datess(date);
                w = 0;
                strelochka(w);
                d = 1;
                break;
            }
            break;
    }
} while (key1.Key != ConsoleKey.Escape);
