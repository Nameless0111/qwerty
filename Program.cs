

namespace rofl
{
    internal class Mein
    {
        static void Main(string[] args)
        {
            int position;
            Menu_and_many_other cakes = new Menu_and_many_other();
            List<Cake> form = new List<Cake>();
            Cake square = new Cake("Квадратный, цена: ", 218);
            form.Add(square);
            Cake circle = new Cake("Круглый, цена: ", 327);
            form.Add(circle);
            Cake piramid = new Cake("Пирамида, цена: ", 4887);
            form.Add(piramid);

            List<Cake> volume = new List<Cake>();
            Cake  first= new Cake("Десятая кубометра, цена: ", 1000);
            volume.Add(first);
            Cake second = new Cake("Пятая кубометра, цена: ", 2000);
            volume.Add(second);
            Cake tenth = new Cake("Кубометр, цена: ", 10000);
            volume.Add(tenth);

            List<Cake> taste = new List<Cake>();
            Cake cream = new Cake("Крем, цена: ", 1000);
            taste.Add(cream);
            Cake chocolate_coconut = new Cake("Шоколадный крем со стружками кокоса, цена: ", 3000);
            taste.Add(chocolate_coconut);
            Cake air = new Cake("Просто полый торт, абсолютно бесплатно: ", 0);
            taste.Add(air);

            List<Cake> amount = new List<Cake>();
            Cake uno = new Cake("1 корж, цена: ", 100);
            amount.Add(uno);
            Cake dos = new Cake("2 коржа, цена: ", 180);
            amount.Add(dos);
            Cake tres = new Cake("3 коржа, цена: ", 250);
            amount.Add(tres);

            List<Cake> glazur = new List<Cake>();
            Cake shocolate = new Cake("Шоколадная, цена: ", 300);
            glazur.Add(shocolate);
            Cake vanil = new Cake("Ванильная, цена: ", 200);
            glazur.Add(vanil);
            Cake chocolate_vanil = new Cake("Шоколадно-ванильная, цена: ", 400);
            glazur.Add(chocolate_vanil);

            List<Cake> decor = new List<Cake>();
            Cake shining_things = new Cake("Съедобные блёстки, цена: ", 70);
            decor.Add(shining_things);
            Cake mushrooms = new Cake("Шоколадные грибочки, цена: ", 200);
            decor.Add(mushrooms);
            Cake eatable_fairies = new Cake("Съедобные феи, цена: ", 700);
            decor.Add(eatable_fairies);

            do
            {
                position = cakes.Menu();
                if (position == 3)
                {
                    cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(form);

                }
                else if (position == 4)
                {
                    cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(volume);

                }
                else if (position == 5)
                {
                    cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(taste);

                }
                else if (position ==6)
                {
                    cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(amount);

                }
                else if (position == 7)
                {
                    cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(glazur);

                }
                else if (position == 8)
                {
                    cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(decor);

                }

            } while (true);








        }
    }
}