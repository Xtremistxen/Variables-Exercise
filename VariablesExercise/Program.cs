using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Record and input these responses for Exercise 1
            //DONE- Name, Favorite Color, Favorite Animal, Favorite Food.


            //For Exercise 2
            //DONE - Create a new method as a math operator "add, subtract, multiply, divide" but allows you to plug in different int

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

            //Is the current player alive? yes if value of health still = positive
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
            decimal myWallet = 0.00m;
            Console.WriteLine($"Currency: {myWallet} Copper");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine(
                "The hero awakens in a dank and dark room, their eyes slowly readjusting to their surroundings noticing they seem to be in a cell like room with metal bars and chains connected to their hands and feet anchoring them to the wall");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("The hero hears a rough sounding voice of an old man hidden in the shadows");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine(
                "The old man says: You have finally awoken I was beginning to worry the guards may have roughed you up to much... Say... you wouldn't mind sparing a few minutes of your time answering question's of a old man would you");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"{name}; So that is your name? how interesting");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("What is your favorite Color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} hahaha that is your Favorite color?");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("What is your favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} That is your favorite animal how bizarre");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            var food = Console.ReadLine();

            Console.WriteLine("Disgusting I would have personally chosen something better...");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            //Added a simple calculator to handle these basic operations Line 156
            Console.WriteLine("Now for some Math questions your favorite... can you Add 2 plus 2? what is the answer?");
            int answer = int.Parse(Console.ReadLine());
            int correctAnswer = Add(2, 2);

            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The answer is {correctAnswer}.");
            }

        }

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

        //Basic math operations methods
        static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        static double Divide(int numOne, int numTwo)
        {
            if (numTwo == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return (double)numOne / numTwo;
        }
    }
}
    
                
            


        
        
        
    
    
 
                
            
        
    

             

        
            
            
            
            
        
            

               
                
                
                
                



        
    

