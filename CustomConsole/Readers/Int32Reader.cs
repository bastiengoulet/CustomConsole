using System;
using System.Collections.Generic;

namespace CustomConsole
{
    public class Int32Reader : Reader
    {
        public override object ReadFromUser(string message)
        {
            ReadFirstInput(message);
            return ValidateInput<Int32>("Entrez un entier valide: ");
        }

        public int ReadNonZeroInt32(string message)
        {
            ReadFirstInput(message);
            return ValidateInput<Int32>("Entrez un nombre entier valide différent de 0: ",
                (output) => output == 0);
        }

        public uint ReadPositiveInt32(string message)
        {
            ReadFirstInput(message);
            return ValidateInput<UInt32>("Entrez un nombre entier valide positif: ");
        }

        public uint ReadPositiveNonZeroInt32(string message)
        {
            ReadFirstInput(message);
            return ValidateInput<UInt32>("Entrez un nombre entier valide positif: ",
                (output) => output == 0);
        }

        public List<int> ReadInt32List(string message)
        {
            ReadFirstInput(message);
            return ValidateListOfInputs<int>();
        }
    }
}
