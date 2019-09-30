using System;
namespace Random_island
{
    class Person
    {
        public string name;
        public int Pol;
        public int Rase;
        public  Spel r1 = new Spel();
        public HitBar H1 = new HitBar();
        //public inventory inv = new inventory(r1);
        public Person(string name, int pol, int rase)
        {
            this.name = name;
            this.Pol = pol;
            this.Rase = rase;
            r1 = new Spel(Pol, Rase);
            H1 = new HitBar(Pol, Rase);
            H1.RedHit(r1);
        }
        public Person()
        {
            Console.WriteLine("Введите имя персонажа");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите пол (1 Органика,2 Бот)");
            this.Pol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рассу(1 Мутант, 2 Человек, 3 Пустотный)");
            this.Rase = Convert.ToInt32(Console.ReadLine());
            r1 = new Spel(Pol, Rase);
            H1 = new HitBar(Pol, Rase);
            H1.RedHit(r1);
        }
        public void print()
        {
            Console.WriteLine("Имя : " + name);
            if (Pol == 1)
                Console.WriteLine("Пол : Органика");
            else if (Pol == 2)
                Console.WriteLine("Пол : Бот");
            if (Rase == 1)
                Console.WriteLine("Раса : Мутант");
            else if (Rase == 2)
                Console.WriteLine("Раса : Человек");
            else if (Rase == 3)
                Console.WriteLine("Раса : Пустотный");
            Console.WriteLine("Стамина : " + r1.stamina);
            Console.WriteLine("Ловкость : " + r1.intelegent);
            Console.WriteLine("Ителект : " + r1.agility);
            Console.WriteLine("Удача : " + r1.lucky);
            Console.WriteLine("Коммуникабильность : " + r1.community);
            Console.WriteLine("ХП: " + H1.hp);
            Console.WriteLine();
           // inv.Many();
        }
    }


}