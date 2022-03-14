using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> taunts = new List<string> 
        {
            "Nice try, Don't do it again!",
            "A graceful taunt is worth a thousand insults",
            "Are you sure you know what you're doing?"

        };

        public override int Roll()
        {
            Console.WriteLine($"{Name} says: {taunts[new Random().Next(0, taunts.Count)]}");
            return new Random().Next(DiceSize) + 1;
        }
    }
}