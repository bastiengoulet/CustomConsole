using System;
using System.Collections.Generic;

namespace CustomConsole
{
    public class DoubleReader : Reader
    {
        public override object ReadFromUser(string message)
        {
            double reel = 0.00f;

            Console.Write(message);
            input = Console.ReadLine();

            while (!double.TryParse(input, out reel))
            {
                Console.Write("Entrez un nombre réel valide: ");
                input = Console.ReadLine();
            }

            return reel;
        }

        public double ReadNonZeroDouble(string message)
        {
            double reel;

            Console.Write(message);
            input = Console.ReadLine();

            while (!double.TryParse(input, out reel) || reel == 0)
            {
                Console.Write("Entrez un nombre réel valide différent de 0: ");
                input = Console.ReadLine();
            }

            return reel;
        }

        public List<double> ReadDoubleList(string message)
        {
            List<double> reels = new List<double>();
            double reel;

            Console.WriteLine(message);
            input = Console.ReadLine();

            while (double.TryParse(input, out reel))
            {
                reels.Add(reel);
                input = Console.ReadLine();
            }

            return reels;
        }

        public double ReadPositiveNonZeroDouble(string message)
        {
            double reel;

            Console.Write(message);
            input = Console.ReadLine();

            while (!double.TryParse(input, out reel) || reel == 0)
            {
                Console.Write("Entrez un nombre réel valide positif: ");
                input = Console.ReadLine();
            }

            return Math.Abs(reel);
        }

        public double ReadDoubleGreaterThan(string message, double lesserLimit)
        {
            double reel;

            Console.Write(message);
            input = Console.ReadLine();

            while (!double.TryParse(input, out reel) || reel <= lesserLimit)
            {
                Console.Write("Entrez un nombre réel valide supérieur à " + lesserLimit.ToString("N2") + "$: ");
                input = Console.ReadLine();
            }

            return reel;
        }

        public void UpdateSalary(string message, ref double currentsalary)
        {
            double reel;

            Console.Write(message);
            input = Console.ReadLine();

            if (!input.Equals(""))
            {
                while (!double.TryParse(input, out reel))
                {
                    Console.Write("Entrez un nombre réel valide positif: ");
                    input = Console.ReadLine();
                }
                currentsalary = reel;
            }
        }
    }
}
