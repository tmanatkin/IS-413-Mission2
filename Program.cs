using Mission_2;

public class Program
{
    private static void Main(string[] args)
    {
        // Initialize Variables
        int numRolls = 0;
        int[] diceRollCounts = new int[0];
        RollDice rd = new RollDice();

        // Get Number of Rolls From User
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");
        numRolls = int.Parse(System.Console.ReadLine());

        // Roll Dice
        diceRollCounts = rd.Roll(numRolls);

        // Output Results
        System.Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.\nTotal Number of Rolls = {numRolls}\n");
        
        // Iterate Through Values, Printing Each Asterisk as 1% of Total Rolls
        for (int i = 0; i < diceRollCounts.Length; i++)
        {
            int numAsterisks = diceRollCounts[i] * 100 / numRolls;
            System.Console.WriteLine($"{i + 2}:\t{new string('*', numAsterisks)}");
        }
    }
}