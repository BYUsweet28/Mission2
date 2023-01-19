using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            //Save the user's input to a numRolls variable
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many times would you like to roll the dice?");
            int numRolls = int.Parse(Console.ReadLine());

            int[] results = new int[numRolls];
            decimal two = 0;
            decimal three = 0;
            decimal four = 0;
            decimal five = 0;
            decimal six = 0;
            decimal seven = 0;
            decimal eight = 0;
            decimal nine = 0;
            decimal ten = 0;
            decimal eleven = 0;
            decimal twelve = 0;


            for (int i = 0; i < numRolls; i++)
            {
                results[i] = (rnd.Next(6) + 1) + (rnd.Next(6) + 1);
                Console.WriteLine(results[i]);
                
                if (results[i] == 2)
                {
                    two += 1;
                }
                else if (results[i] == 3)
                {
                    three += 1;
                }
                else if (results[i] == 4)
                {
                    four += 1;
                }
                else if (results[i] == 5)
                {
                    five += 1;
                }
                else if (results[i] == 6)
                {
                    six += 1;
                }
                else if (results[i] == 7)
                {
                    seven += 1;
                }
                else if (results[i] == 8)
                {
                    eight += 1;
                }
                else if (results[i] == 9)
                {
                    nine += 1;
                }
                else if (results[i] == 10)
                {
                    ten += 1;
                }
                else if (results[i] == 11)
                {
                    eleven += 1;
                }
                else if (results[i] == 12)
                {
                    twelve += 1;
                }
            }
            Console.WriteLine(two/numRolls);
            //Console.WriteLine(Math.Round((two / numRolls) * 100), 0);
            decimal[] asterisks = {Math.Round((decimal)(two / numRolls) * 100, 0), Math.Round((decimal)(three / numRolls) * 100, 0), Math.Round((decimal)(four / numRolls) * 100, 0), Math.Round((decimal)(five / numRolls) * 100, 0), Math.Round((decimal)(six / numRolls) * 100, 0), Math.Round((decimal)(seven / numRolls) * 100, 0), Math.Round((decimal)((eight / numRolls) * 100), 0), Math.Round((decimal)((nine / numRolls) * 100), 0), Math.Round((decimal)((ten / numRolls) * 100), 0), Math.Round((decimal)((eleven / numRolls) * 100), 0), Math.Round((decimal)((twelve / numRolls) * 100), 0)};

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each " + "*" + " represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".");

            for(int i = 0; i <= 10; i++)
            {
                string output = (i + 2) + ": ";
                for(int a = 0; a < asterisks[i]; a++)
                {
                    output += "*";
                }
                Console.WriteLine(output);
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
