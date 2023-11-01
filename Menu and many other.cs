using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rofl
{
    internal class Menu_and_many_other
    {
        DateTime time = DateTime.Now;
        public int total_cost = 0;
        public int pos = 3;
        public string haracteristika = "";
        int c = 1;
        ConsoleKeyInfo key;
        public int Menu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" Заказ тортов оптом  в тортовой тортового тортовика.");
            Console.WriteLine(" -__-__-__-__-__-__-__-__-__-__-__-__-");
            Console.WriteLine(" Требуемые характеристики изделия: ");
            Console.WriteLine("  1. Форма");
            Console.WriteLine("  2. Размер");
            Console.WriteLine("  3. Вкус");
            Console.WriteLine("  4. Количество коржей");
            Console.WriteLine("  5. Глазурь");
            Console.WriteLine("  6. Декор");
            Console.WriteLine("  Сохранить заказ");
            Console.WriteLine("Стоимость заказа: " + total_cost);
            Console.WriteLine("Выбранные позиции:" + haracteristika);


            do
            {
                Console.SetCursorPosition(0, pos);
                Console.Write("=>");
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 3)
                    {
                        pos++;
                        Console.Clear();
                        Menu();
                    }
                    else
                        Console.Clear();
                    c = 1;
                    Menu();
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > 9)
                    {
                        pos--;
                        Console.Clear();
                        Menu();
                    }
                    else
                        Console.Clear();
                    c = 1;
                    Menu();
                }


                if (key.Key == ConsoleKey.Enter && pos == 9)
                {
                    Console.WriteLine("Заказ готов,теперь вам нужно построить кондитерскую, ха-ха");
                    Console.WriteLine("Вернитесь назад с помощью двойного нажатия Esc");
                    Save(total_cost, haracteristika);
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    return pos;
                }
            } while (key.Key != ConsoleKey.Escape);
            total_cost = 0;
            haracteristika = "";
            return 1;
        }
        private void Save(int total_cost, string haracteristika)
        {
            if (!File.Exists("D:\\Учеба\\оаип скорогудаева\\balabala.txt"))
            {
                File.Create("D:\\Учеба\\оаип скорогудаева\\balabala.txt");
            }

            File.AppendAllText("D:\\Учеба\\оаип скорогудаева\\balabala.txt", "\nВремя: " + time + "\nСодержание: " + haracteristika + " " + "\nОбщая цена: " + total_cost + "\n\t");

            ConsoleKeyInfo key;
            key = Console.ReadKey();
            Console.Clear();
            Menu(); 


        }
        public void Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(List<Cake> list)
        {
            int position = 0;
            do
            {
                
                Console.Clear();
                foreach (Cake Cake in list)
                {
                    Console.WriteLine("    " + Cake.namee + " " + Cake.cenaa);

                }
                Console.WriteLine("Enter - выбор, Escape - возврат");
                if (key.Key == ConsoleKey.Enter)
                {

                    if (c != 1) { 
                        Console.WriteLine("Сохранено");

                    }
                    c = 2;
                }
                Console.SetCursorPosition(0, position);
                Console.Write("=>");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow && position >= 1)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow && position < list.Count - 1)
                {
                    position++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    haracteristika += list[position].namee + "  " + list[position].cenaa + ";" + "\n";
                    total_cost += list[position].cenaa;
                }
            } while (key.Key != ConsoleKey.Escape);
            Menu();
        }
    }
}