

namespace rofl
{
    internal class Mein
    {
        static void Main(string[] smth)
        {
            int pos2;
            Menu_and_many_other cakes = new Menu_and_many_other();
            List<Cake> volume = new List<Cake>();
            List<Cake> form = new List<Cake>(); 
            List<Cake> taste = new List<Cake>();
            List<Cake> amount = new List<Cake>();
            List<Cake> glazur = new List<Cake>();
            List<Cake> decor = new List<Cake>();
            Cake square = new Cake("Квадратный, цена: ", 218);
            Cake circle = new Cake("Круглый, цена: ", 327);
            Cake piramid = new Cake("Пирамида, цена: ", 4887);
            form.Add(piramid);
            form.Add(square);        
            form.Add(circle);
            Cake  first= new Cake("Десятая кубометра, цена: ", 1000);
            Cake second = new Cake("Пятая кубометра, цена: ", 2000);
            Cake tenth = new Cake("Кубометр, цена: ", 10000);
            volume.Add(first);
            volume.Add(second);
            volume.Add(tenth);            
            Cake cream = new Cake("Крем, цена: ", 1000);
            Cake chocolate_coconut = new Cake("Шоколадный крем со стружками кокоса, цена: ", 3000);
            Cake air = new Cake("Просто полый торт, абсолютно бесплатно: ", 0);
            taste.Add(air);
            taste.Add(cream);
            taste.Add(chocolate_coconut);
            Cake uno = new Cake("1 корж, цена: ", 100);
            Cake dos = new Cake("2 коржа, цена: ", 180);
            Cake tres = new Cake("3 коржа, цена: ", 250);
            amount.Add(uno);
            amount.Add(dos);
            amount.Add(tres);
            Cake shocolate = new Cake("Шоколадная, цена: ", 300);
            Cake vanil = new Cake("Ванильная, цена: ", 200);
            Cake chocolate_vanil = new Cake("Шоколадно-ванильная, цена: ", 400);
            glazur.Add(shocolate);
            glazur.Add(vanil);
            glazur.Add(chocolate_vanil);
            Cake shining_things = new Cake("Съедобные блёстки, цена: ", 70);
            Cake mushrooms = new Cake("Шоколадные грибочки, цена: ", 200);
            Cake eatable_fairies = new Cake("Съедобные феи, цена: ", 700);
            decor.Add(shining_things);
            decor.Add(mushrooms);
            decor.Add(eatable_fairies);
            do
            {
                pos2 = cakes.Menu();
                switch (pos2)
                {
                    case 3: cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(form);break;
                    case 4: cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(volume);break;
                    case 5: cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(taste);break;
                    case 6:cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(amount);break;
                    case 7: cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(glazur);break;
                    case 8: cakes.Mnogo_povtoryaushihsya_skuchnih_bukovok_v_maine(decor);break;

                }
            } while (true);
        }
    }
}
