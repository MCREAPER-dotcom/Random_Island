namespace Random_island
{
    class HitBar
    {
        public int hp;
        public int armor;
        public HitBar()
        {
            this.hp = 100;
            this.armor = 0;
        }
        public void RedHit(Spel r1) {
            if (r1.stamina > 0 && armor > 0)
                hp = hp + (armor / 2 * r1.stamina / 2 * hp / 2) /10;
            else if (r1.stamina > 0)
                hp = hp + (r1.stamina / 2 * hp / 2) / 10;
            else if (armor > 0)
                hp = hp + (armor / 2 * hp / 2) / 10;
            else
                hp = hp*hp/10;
        }
        public HitBar(int pol, int rase)
        {

            if (pol == 1)
            {
                hp += 200;
                armor += 1;
            }
            else if (pol == 2)
            {
                hp += 100;
                armor += 3;
            }
            else
            {
                hp = 100;
                armor = 0;
            }
            if (rase == 1)
            {
                hp += 300;
                armor += 4;
            }
            else if (rase == 2)
            {
                hp += 200;
                armor += 2;
            }
            else if (rase == 3)
            {
                hp += 100;
                armor += 1;
            }
            else
            {
                hp = 100;
                armor = 0;
            }
        }
        public void ADD(int hp, int armor)
        {
            this.hp += hp;
            this.armor += armor;
        }

    }

}