using System.Media;
Console.WriteLine("Переключение между октавами F2 F3 F4 F5 F6 F7 F8 F9(по умолчанию стоит F5 - малая октава)");
Console.WriteLine("Белые клавишы - символы от a по j(кроме F9 и F2, в случае F9 только символ a из-за особенностей октавы, а в случае F2 символы с d по j)");
Console.WriteLine("Чёрные клавишы - символы от q по t(кроме F9 и F2, в случае F9 нет символов из-за особенностей октавы,а в случае F2 символы с w по t) ");
Console.WriteLine("Выход - Esc");
ConsoleKeyInfo key = Console.ReadKey();
 void hz(int hz)
{
    Console.Beep(hz, 150);
}
 int[] smenaOct(int oct)
{
   /* int[] SubContrOct= new int[]    {
         27, 29, 30};*/
    int[] ContrOct = new int[]    {
         37, 37, 37, 38, 41, 43, 46, 48, 51, 55, 58, 61};//так как частоты в субконтроктаве заблокированы то они и все что с ними связано побудет в комментариях,а в контроктаве будет доступна лишь часть
    int[] GreatOct = new int[]    {
         65, 69, 73, 77, 82, 87,92, 97, 103, 110, 116, 123};
    int[] Smalloct = new int[]    {
         130, 138, 146, 155, 164, 174, 184, 195, 207, 220, 233, 246};
    int[] first = new int[]    {
         261, 277, 293, 311, 329, 349, 369, 391, 415, 440, 456, 493};
    int[] second = new int[]    {
        523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987};
    int[] thierd = new int[]    {
         1046, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
    int[] fourth = new int[]    {
         2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951};
    int[] fifth = new int[]    {
         4186,37,37,37,37,37,37,37,37,37,37,37};
   /* if (oct == 1)
    {
        return SubContrOct;
    }
    else*/ if (oct == 2)
    {
        return ContrOct;
    }
    else if (oct == 3)
    {
        return GreatOct;
    }
    else if (oct == 4)
    {
        return Smalloct;
    }
    else if (oct == 5)
    {
        return first;
    }
    else if (oct == 6)
    {
        return second;
    }
    else if (oct == 7)
    {
        return thierd;
    }
    else if (oct == 8)
    {
        return fourth;
    }
    else if (oct == 9)
    {
        return fifth;
    }
    return first;
}

ConsoleKeyInfo key1; int[] oct = smenaOct(5);
do
{
    key1 = Console.ReadKey(true); switch (key1.Key)
    {

        /*case ConsoleKey.F1: oct = smenaOct(1); break;*/
        case ConsoleKey.F2: oct = smenaOct(2); break;
        case ConsoleKey.F3: oct = smenaOct(3); break;
        case ConsoleKey.F4: oct = smenaOct(4); break;
        case ConsoleKey.F5: oct = smenaOct(5); break;
        case ConsoleKey.F6: oct = smenaOct(6); break;
        case ConsoleKey.F7: oct = smenaOct(7); break;
        case ConsoleKey.F8: oct = smenaOct(8); break;
        case ConsoleKey.F9: oct = smenaOct(9); break;

        case ConsoleKey.A:
            if (oct != smenaOct(2))
            {
                hz(oct[0]);
            }
            break;
        case ConsoleKey.Q:
            if (oct != smenaOct(9) && oct != smenaOct(2))
            { 
            hz(oct[1]);
            }
            break;
        case ConsoleKey.S:
            if (oct != smenaOct(9) && oct != smenaOct(2))
            {
                hz(oct[2]);
            }
            break;
        case ConsoleKey.W:
            if (oct != smenaOct(9))
            {
                hz(oct[3]);
            }
            break;
        case ConsoleKey.D:
            if (oct != smenaOct(9))
            {
                hz(oct[4]);
            }
            break;
        case ConsoleKey.F:
            if (oct != smenaOct(9))
            {
                hz(oct[5]);
            }
            break;
        case ConsoleKey.E:
            if (oct != smenaOct(9))
            {
                hz(oct[6]);
            }
            break;
        case ConsoleKey.G:
            if (oct != smenaOct(9))
            {
                hz(oct[7]);
            }
            break;
        case ConsoleKey.R:
            if (oct != smenaOct(9))
            {
                hz(oct[8]);
            }
            break;
        case ConsoleKey.H:
            if (oct != smenaOct(9))
            {
                hz(oct[9]);
            }
            break;
        case ConsoleKey.T:
            if (oct != smenaOct(9))
            {
                hz(oct[10]);
            }
            break;
        case ConsoleKey.J:
            if (oct != smenaOct(9))
            {
                hz(oct[11]);
            }
            break;
    }
} while (key1.Key != ConsoleKey.Escape);