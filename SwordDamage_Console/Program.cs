using System;

namespace SwordDamage_Console
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            SwordDamage swordDamage = new SwordDamage();
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;     
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.setFlaming(key == '2' || key == '3');
                Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP");
            }

        }
    }
}
