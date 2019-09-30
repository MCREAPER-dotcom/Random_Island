using System;
namespace Random_island
{
    class enemy
    {
        public string Name;
        public int Pol;
        public int Rase;
        public int Cost;
        public Spel r2 = new Spel();
        public HitBar H1 = new HitBar();
        
        Random rand = new Random();
        public enemy()
        {
            Array values = Enum.GetValues(typeof(EnemyName));
            Array values1 = Enum.GetValues(typeof(EnemyFirstName));
            this.Name = Enum.GetName(typeof(EnemyName), rand.Next(values.Length)) + " " + Enum.GetName(typeof(EnemyFirstName), rand.Next(values1.Length));
            this.Pol = rand.Next() % 2 + 1;
            this.Rase = rand.Next() % 3 + 1;
            r2 = new Spel(Pol, Rase);
            H1 = new HitBar(Pol, Rase);
            H1.RedHit(r2);
            Cost = H1.hp / 10 + (r2.agility + r2.community + r2.intelegent + r2.lucky * 10 + r2.stamina);
        }
        public enemy(string name, int pol, int rase)
        {
            this.Name = name;
            this.Pol = pol;
            this.Rase = rase;
            r2 = new Spel(Pol, Rase);
            H1 = new HitBar(Pol, Rase);
            H1.RedHit(r2);
            Cost = H1.hp / 10 + (r2.agility + r2.community + r2.intelegent + r2.lucky * 10 + r2.stamina);
        }
        public void print()
        {
            Console.WriteLine("Имя : " + Name);
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
            Console.WriteLine("Стамина : " + r2.stamina);
            Console.WriteLine("Ловкость : " + r2.intelegent);
            Console.WriteLine("Ителект : " + r2.agility);
            Console.WriteLine("Удача : " + r2.lucky);
            Console.WriteLine("Коммуникабильность : " + r2.community);
            Console.WriteLine();
            Console.WriteLine("ХП: " + H1.hp);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Награда: "+Cost);
        }
    }

}