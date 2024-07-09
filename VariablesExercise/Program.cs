using System.Net.NetworkInformation;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //USER WILL ENTER THE NAME OF THEIR CHARACTER
            Console.WriteLine("Give me your name Hero:");

            string charName = Console.ReadLine();
                
                Console.WriteLine($"Welcome,{charName} to your doom!");
                
                //Current lvl of the new character will always be 1
                int lvlNumber = 1;

                Console.WriteLine($"Currently level 1");
                
                //New user will always start at 100 health
                double currentHealth = 100.00;
                
                Console.WriteLine($"Current Health 100");
                
                //Is the current character alive? yes if value of health still = positive
                bool charAlive = true;
                
                //Character current stats Strength, Dexterity, Intelligence, Wisdom, Constitution, Charisma(use H) X is variable stat 
                char stats = 'x';
                
                Console.WriteLine($"Strength: 10");
                Console.WriteLine($"Dexterity: 12");
                Console.WriteLine($"Intelligence: 2");
                Console.WriteLine($"Wisdom: 1");
                Console.WriteLine($"Constitution: 1");
                Console.WriteLine($"Charisma: 99");

                //New user will always start with 10 copper to their name!
                decimal myWallet = 10.00m;
                
                Console.WriteLine($"Currency: 10 Copper in purse you are poor! not enough to even afford scraps!");
                
                
                
                



        }
    }
}
