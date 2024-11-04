using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230053
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continueRolling = true;

            while (continueRolling)
            {
                Console.WriteLine("Welcome to the Dice Roller!");

                Console.Write("Enter the number of SIDES on the dice: ");
                int sides = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of DICE to roll: ");
                int numberOfDice = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of TIMES to roll: ");
                int numberOfRolls = int.Parse(Console.ReadLine());

                List<List<int>> allRollResults = new List<List<int>>();

                for (int i = 0; i < numberOfRolls; i++)
                {
                    List<int> rollResults = new List<int>();

                    Console.WriteLine($"\nRoll {i + 1}:");

                    for (int j = 0; j < numberOfDice; j++)
                    {
                        Dice dice = new StandardDice(sides);
                        int result = dice.Roll();
                        rollResults.Add(result);
                        Console.WriteLine($"Dice {j + 1}: {result}");
                    }

                    allRollResults.Add(rollResults);
                }

                Console.WriteLine("\nSummary:");
                Console.WriteLine($"- Number of Sides: {sides}");
                Console.WriteLine($"- Number of Dice: {numberOfDice}");
                Console.WriteLine($"- Number of Rolls: {numberOfRolls}");

                Console.WriteLine("\nRoll Results:");
                for (int i = 0; i < allRollResults.Count; i++)
                {
                    Console.Write($"Roll {i + 1}: ");
                    Console.WriteLine(string.Join(", ", allRollResults[i]));
                }

                Console.Write("\nWould you like to roll again? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();
                continueRolling = response == "Y";
            }

            Console.WriteLine("Thank you for using the Dice Roller!");
        }
    }
}
