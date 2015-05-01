using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class DiceGenerator
    {
        Random random = new Random();
        static void Main(string[] args)
        {
            DiceGenerator diceGenerator = new DiceGenerator();
            int wins = diceGenerator.findNumberOfWins();
            bool hasWon = diceGenerator.hasWonPrize(wins);
            Console.WriteLine("The user {0} the prize",hasWon? "has won":"has not won");
        }

        public int rollDice()
        {
           return random.Next(1, 7);
        }

        public int findNumberOfWins()
        {
            int chances = 10;
            int wins = 0;
            while (chances > 0)
            {
                int value = rollDice();
                Console.WriteLine("Value on dice is "+ value);
                if ( value == 6)
                {
                    wins++; // if he gets 6 he wins the round
                }

                chances--; // as user plays chances will reduce ...
            }
            return wins;
        }

        public bool hasWonPrize(int wins)
        {
            return (wins >= 3);
        }

        
    }



}
