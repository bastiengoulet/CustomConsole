using System;
using System.Collections.Generic;

namespace CustomConsole
{
    public class Int32Reader : Reader
    {
        public override object ReadFromUser(string message)
        {
            int entier = 0;

            Console.Write(message);
            input = Console.ReadLine();

            while (!Int32.TryParse(input, out entier))
            {
                Console.Write("Entrez un entier valide: ");
                input = Console.ReadLine();
            }

            return entier;
        }

        public int ReadNonZeroInt32(string message)
        {
            int entier;

            Console.Write(message);
            input = Console.ReadLine();

            while (!Int32.TryParse(input, out entier) || entier == 0)
            {
                Console.Write("Entrez un nombre entier valide différent de 0: ");
                input = Console.ReadLine();
            }

            return entier;
        }

        public uint ReadPositiveInt32(string message)
        {
            uint entier;

            Console.Write(message);
            input = Console.ReadLine();

            while (!UInt32.TryParse(input, out entier))
            {
                Console.Write("Entrez un nombre entier valide positif: ");
                input = Console.ReadLine();
            }

            return entier;
        }

        public uint ReadPositiveNonZeroInt32(string message)
        {
            uint entier;

            Console.Write(message);
            input = Console.ReadLine();

            while (!UInt32.TryParse(input, out entier) || entier == 0)
            {
                Console.Write("Entrez un nombre entier valide positif: ");
                input = Console.ReadLine();
            }

            return entier;
        }

        public List<int> ReadInt32List(string message)
        {
            List<int> entiers = new List<int>();
            int entier;

            Console.WriteLine(message);
            input = Console.ReadLine();

            while (Int32.TryParse(input, out entier))
            {
                entiers.Add(entier);
                input = Console.ReadLine();
            }

            return entiers;
        }
    }
}
