using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter a Number Between 1-6 for your roll");
            string HumanRoll = Console.ReadLine();

            int myRoll = int.Parse(HumanRoll);

            return myRoll;
        }
    }
}