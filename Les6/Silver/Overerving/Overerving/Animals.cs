using System;

namespace Overerving
{
    class Animals
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();

            Console.WriteLine(horse.IsFed());

            horse.Feed();

            Console.WriteLine(horse.IsFed());
        }
    }

    class Animal
    {
        internal bool isFed;

        public virtual void Feed()
        {
            isFed = true;
        }

        internal bool IsFed()
        {
            return isFed;
        }
    }

    class Horse : Animal
    {
        internal int FeedAmount = 0;
        internal const int NeedsFeedAmount = 10;

        public override void Feed()
        {
            Horse horse = new Horse();
            FeedAmount = FeedAmount + NeedsFeedAmount;
            FeedAmount += 1;
            if (FeedAmount >= NeedsFeedAmount)
            {
                base.Feed();
                
            }
        }
    }
}