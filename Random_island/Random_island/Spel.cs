namespace Random_island
{
    class Spel
    {
        public int stamina;
        public int intelegent;
        public int agility;
        public int lucky;
        public int community;
        public Spel()
        {
            stamina = 0;
            intelegent = 0;
            agility = 0;
            lucky = 0;
            community = 0;
        }
        public Spel(int s, int i, int a, int l, int c)
        {
            this.stamina = s;
            this.intelegent = i;
            this.agility = a;
            this.lucky = l;
            this.community = c;
        }
        public Spel(int pol, int rase)
        {
            if (pol == 1)
            {
                this.stamina = 6;
                this.intelegent = 5;
                this.agility = 5;
                this.lucky = 3;
                this.community = 5;
            }
            else if (pol == 2)
            {
                this.stamina = 3;
                this.intelegent = 5;
                this.agility = 5;
                this.lucky = 6;
                this.community = 7;
            }
            else
            {
                this.stamina = 0;
                this.intelegent = 0;
                this.agility = 0;
                this.lucky = 0;
                this.community = 0;
            }
            if (rase == 1)
            {
                this.stamina += 2;
                this.intelegent += 1;
                this.agility -= 2;
                this.lucky += 4;
                this.community -= 5;
            }
            else if (rase == 2)
            {
                this.stamina += 1;
                this.intelegent -= 1;
                this.agility += 1;
                this.lucky -= 1;
            }
            else if (rase == 3)
            {
                this.stamina -= 3;
                this.intelegent += 2;
                this.agility -= 2;
                this.lucky += 2;
                this.community += 1;
            }
            else
            {
                this.stamina = 0;
                this.intelegent = 0;
                this.agility = 0;
                this.lucky = 0;
                this.community = 0;
            }
        }
    }




}