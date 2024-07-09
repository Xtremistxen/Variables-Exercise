using System.Net.NetworkInformation;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
//DONE create string
//DONE create int
//DONE create char
//Done create bool
//DONE create double
//DONE create decimal

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
            char stats = 'x'; //An example not in use
            char strengthGrade = 'A';
            char dexterityGrade = 'C';
            char intelligenceGrade = 'B';
            char wisdomGrade = 'F';
            char constitutionGrade = 'D';
            char charismaGrade = 'E';

            double strengthValue = convertCharToDouble(strengthGrade);
            double dexterityValue = convertCharToDouble(dexterityGrade);
            double intelligenceValue = convertCharToDouble(intelligenceGrade);
            double wisdomValue = convertCharToDouble(wisdomGrade);
            double constitutionValue = convertCharToDouble(constitutionGrade);
            double charismaValue = convertCharToDouble(charismaGrade);

            Console.WriteLine($"Strength: {strengthValue}");
            Console.WriteLine($"Dexterity: {dexterityValue}");
            Console.WriteLine($"Intelligence: {intelligenceValue}");
            Console.WriteLine($"Wisdom: {wisdomValue}");
            Console.WriteLine($"Constitution: {constitutionValue}");
            Console.WriteLine($"Charisma: {charismaValue}");

            //New user will always start with 10 copper
            decimal myWallet = 10.00m;
            Console.WriteLine($"Currency: {myWallet} Copper");
            Console.WriteLine ($"10 Copper in purse you are poor! not enough to even afford scraps!");

             //High to low stats LEARNED HOW TO USE GRADE!!! oufe
            static double convertCharToDouble(char grade)
            {
                switch (grade)
                {
                    case 'A':
                        return 9.0;
                    case 'B':
                        return 8.0;
                    case 'C':
                        return 7.0;
                    case 'D':
                        return 6.0;
                    case 'E':
                        return 5.0;
                    case 'F':
                        return 4.0;
                    default:

                        throw new ArgumentException("Invalid grade.");
                }
            }
            
            
        
            

               
                
                
                
                



        }
    }
}
