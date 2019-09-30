using System;
namespace Random_island
{
    struct Qustion
    {
        public static bool Yes_No()
        {
            string After_FAit;
            After_FAit = Console.ReadLine();
            if (After_FAit == "Да" || After_FAit == "да" || After_FAit == "Yes" || After_FAit == "yes"|| After_FAit == "1")
                return true;
            else 
                return false;
        }
    }

}