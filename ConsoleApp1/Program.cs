
Console.WriteLine("Сколько ложек сахара хотите?");
string txt = Console.ReadLine();
int zxc = Convert.ToInt32(txt);
for (int zxcv = 0; zxcv <= zxc; zxcv++)
{
    Console.WriteLine("Добавил " + zxcv + " ложек сахара");
 
}
for (int i = 1000; 0 <= i; i -=7)
{
    Console.WriteLine(i);
}
bool ist;
do
{
   Console.WriteLine("Говорю");
   Console.WriteLine("Меня слушают?");
   bool.TryParse(Console.ReadLine(), out ist);
   Console.WriteLine(ist);
} while (ist == true);

string colour;
do
{
    Console.WriteLine("Выбери цвет");
    Console.WriteLine("1. Синий");
    Console.WriteLine("2.Зеленый");
    Console.WriteLine("1. Красный");
    Console.WriteLine("4. Выход");
    colour = Console.ReadLine();

    switch (colour)
    {
        case "1":
            Console.WriteLine("wdbiwhabs");
            break;
        case "2":
            Console.WriteLine("ewobd");
            break;
        case "3":
            Console.WriteLine("eubcdakh");
            break;
        case "4":
            Console.WriteLine("wqnd");
                 break;
    }
}while (colour != "4");