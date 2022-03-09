using System;
using System.Collections.Generic;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numThreads;
            int numThrows;

            Console.WriteLine("How many threads would you like to use?");
            string numThreadsString = Console.ReadLine();
            numThreads = int.Parse(numThreadsString);
        }
    }

    class FindPiThread
    {
        int darts;
        int hits;
        Random rand = new Random();

        public FindPiThread(int darts){
            this.darts = darts;
            hits = 0;
            Random rand = new Random();
        }

        public void throwDarts()
        {
            for(int i = 0; i < darts; i++)
            {
                double x = rand.NextDouble();
                double y = rand.NextDouble();
                if(findHypotense(x, y) <= 1)
                    hits++;
            }
        }

        public double findHypotense(double x, double y)
        {
            double h = (x * x) + (y * y);
            h = Math.Sqrt(h);
            return h;
        }

    }

    
}
