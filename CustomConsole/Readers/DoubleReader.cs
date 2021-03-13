using System.Collections.Generic;

namespace CustomConsole
{
    public class DoubleReader : Reader
    {
        public override object ReadFromUser(string message)
        {
            ReadFirstInput(message);
            return ValidateInput<double>("Entrez un nombre réel valide: ");
        }

        public double ReadNonZeroDouble(string message)
        {
            ReadFirstInput(message);
            return ValidateInput<double>("Entrez un nombre réel valide différent de 0: ", 
                (output) => output == 0);
        }

        public List<double> ReadDoubleList(string message)
        {
            ReadFirstInput(message);
            return ValidateListOfInputs<double>();
        }

        public double ReadPositiveNonZeroDouble(string message)
        {
            ReadFirstInput(message);
            return ValidateInput<double>("Entrez un nombre réel valide positif: ", 
                (output) => output <= 0);
        }

        public double ReadDoubleGreaterThan(string message, double lesserLimit)
        {
            ReadFirstInput(message);
            return ValidateInput<double>($"Entrez un nombre réel valide supérieur à {lesserLimit.ToString("N2")}$: ", 
                (output) => output <= lesserLimit);
        }
    }
}
