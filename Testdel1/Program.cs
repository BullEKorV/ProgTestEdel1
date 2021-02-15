using System;
namespace Testdel1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabeln hp
            int hp;
            // Läs av användarens input
            Console.WriteLine("Skriv in ett värde på ditt hp mellan 1-20");
            string hpString = Console.ReadLine();
            // Se om hp är inom rätt range och ett nummers
            int.TryParse(hpString, out hp);
            while (!(hp <= 20 && hp >= 1))
            {
                if (!int.TryParse(hpString, out hp)) Console.WriteLine("That's not a number"); // Ge fel meddelande till användare
                else if (hp > 20 || hp < 1) Console.WriteLine("HP must be in the range of 1-20");
                hpString = Console.ReadLine();
                int.TryParse(hpString, out hp); // testa att göra input till ett heltal
            }

            //Skriv ut HealthBar
            int tempHp = hp;
            for (int i = 0; i < tempHp; i++)
            {
                Console.WriteLine(Health(hp)); // Skriv ut funktionen "Health" med variabeln "hp"
                hp--;
            }
            //Klar
            Console.ReadLine();

        }
        static string Health(int hp) //Draw the healthBar with int hp
        {
            string healthBar = "[";
            for (int i = 0; i < hp; i++)
            {
                healthBar += "=";
            }
            healthBar += "]";
            return healthBar;
        }
    }
}
