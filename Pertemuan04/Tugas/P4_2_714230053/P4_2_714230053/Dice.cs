using System;

namespace P4_2_714230053
{
    public abstract class Dice
    {
        private int sides;

        public int Sides
        {
            get { return sides; }
            protected set
            {
                if (value < 2 || value > 258) throw new ArgumentException("A dice must have at least 2 sides and no more than 258 sides.");
                sides = value;
            }
        }

        protected Dice(int sides)
        {
            Sides = sides;
        }

        public abstract int Roll();
    }
}
