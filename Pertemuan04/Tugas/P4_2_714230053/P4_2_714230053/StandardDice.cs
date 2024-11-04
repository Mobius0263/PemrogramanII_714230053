using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230053
{
    public class StandardDice : Dice
    {
        private static Random random = new Random();

        public StandardDice(int sides) : base(sides) { }

        public override int Roll()
        {
            return random.Next(1, Sides + 1);
        }
    }
}
