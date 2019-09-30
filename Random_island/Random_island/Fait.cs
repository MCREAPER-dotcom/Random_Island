using System;
namespace Random_island
{
    class HIT
    {
        int hit1, hit2;
        int  k;
        public void faite(ref Person p1, enemy e1)
        {
            Random rand = new Random();
            int rnd2 = rand.Next() % 50;
            int rnd = rand.Next() % 2 + 1;
            /////////////////////////////////////////////////////////////////////////////////
            int d1, d2;
            hit1 = p1.H1.hp;
            hit2 = e1.H1.hp;
            if (rnd == 1)
            {
                Console.WriteLine("Жребий брошен Будет произведено " + (rnd2+1) + " удара");
                Console.WriteLine(p1.name + " | " + e1.Name);
                for (int i = 0; i <= rnd2; i++)
                {
                    k++;
                    d1 = rand.Next() % 100 ;
                    d2 = rand.Next() % 100 ;
                    if (rand.Next() % 2 + 1 == 1)
                    {
                        Console.WriteLine(k + " | " + hit1 + " | " + hit2 + " | Нанес " + d2 + " | Получил " + d1);
                        hit2 = hit2 - d2;
                        if (hit1 <= 0) { Console.WriteLine("Вы успешно проиграли битву :^) "); System.Threading.Thread.Sleep(4000);LastPage.print(); break; }
                        hit1 = hit1 - d1;
                        if (hit2 <= 0) { Console.WriteLine("Тебе просто повеезло"); hit2 = hit2 - d2; System.Threading.Thread.Sleep(1000);/*p1.inv.many += e1.Cost;*/ break; }
                    }
                    else
                    {
                        Console.WriteLine(k + " | " + hit1 + " | " + hit2 + " | Получил " + d2 + " | Нанес " + d1);
                        hit1 = hit1 - d2;
                        if (hit1 <= 0) { Console.WriteLine("Вы успешно проиграли битву :^) "); System.Threading.Thread.Sleep(4000); LastPage.print(); break; }
                        hit2 = hit2 - d1;
                        if (hit2 <= 0) { Console.WriteLine("Тебе просто повеезло"); System.Threading.Thread.Sleep(1000);/* p1.inv.many += e1.Cost;*/ break; }
                    }

                }
                if (hit2 > 0&& hit1>0) Console.WriteLine("Вы успешно сбежали, возможно противник не смог устоять от вашей крутизны");
                p1.H1.hp = hit1;
            }
            else
            {
                Console.WriteLine(p1.name + " | " + e1.Name);
                hit1 = p1.H1.hp;
                hit2 = e1.H1.hp;
                while (hit1 > 0 && hit2 > 0)
                {
                    k++;
                    d1 = rand.Next() % 100 ;
                    d2 = rand.Next() % 100 ;
                    if (rand.Next() % 2 + 1 == 1)
                    {
                        Console.WriteLine(k + " | " + hit1 + " | " + hit2 + " | Нанес " + d2 + " | Получил " + d1);
                        hit2 = hit2 - d2;
                        if (hit1 <= 0) { Console.WriteLine("Вы успешно проиграли битву :^) "); System.Threading.Thread.Sleep(4000); LastPage.print(); break; }
                        hit1 = hit1 - d1;
                        if (hit2 <= 0) { Console.WriteLine("Тебе просто повеезло"); System.Threading.Thread.Sleep(1000);/* p1.inv.many += e1.Cost; */break; }
                    }
                    else
                    {
                        Console.WriteLine(k + " | " + hit1 + " | " + hit2 + " | Получил " + d2 + " | Нанес " + d1);
                        hit1 = hit1 - d2;
                        if (hit1 <= 0) { Console.WriteLine("Вы успешно проиграли битву :^) "); System.Threading.Thread.Sleep(4000); LastPage.print(); break; }
                        hit2 = hit2 - d1;
                        if (hit2 <= 0) { Console.WriteLine("Тебе просто повеезло"); System.Threading.Thread.Sleep(1000); /*p1.inv.many += e1.Cost; */break; }
                    }
                }
                p1.H1.hp = hit1;
            }
            
        }
    }




}