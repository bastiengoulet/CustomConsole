using System;

namespace CustomConsole
{
    public class StringReader : Reader
    {
        public override object ReadFromUser(string message)
        {
            Console.Write(message);
            input = Console.ReadLine();

            while (input.Length == 0)
            {
                Console.Write("Entrez une chaîne de caractères valide: ");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
