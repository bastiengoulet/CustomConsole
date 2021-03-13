using System.Collections.Generic;

namespace CustomConsole
{
    /*
        * Cette classe utilise le design pattern de la Façade
        * Informations trouvées dans la page suivante: https://www.dofactory.com/net/facade-design-pattern
    */
    public static class CustomConsole
    {
        private static StringReader stringReader = new StringReader();
        private static DoubleReader doubleReader = new DoubleReader();
        private static Int32Reader int32Reader = new Int32Reader();

        public static string ReadString(string message)
        {
            return stringReader.ReadFromUser(message).ToString();
        }

        public static double ReadDouble(string message)
        {
            return (double)doubleReader.ReadFromUser(message);
        }

        public static double ReadNonZeroDouble(string message)
        {
            return doubleReader.ReadNonZeroDouble(message);
        }

        public static List<double> ReadDoubleList(string message)
        {
            return doubleReader.ReadDoubleList(message);
        }

        public static double ReadPositiveDouble(string message)
        {
            return doubleReader.ReadPositiveNonZeroDouble(message);
        }

        public static double ReadDoubleGreaterThan(string message, double lesserLimit)
        {
            return doubleReader.ReadDoubleGreaterThan(message, lesserLimit);
        }

        public static void UpdateSalary(string message, ref double currentsalary)
        {
            doubleReader.UpdateSalary(message, ref currentsalary);
        }

        public static int ReadInt32(string message)
        {
            return (int)int32Reader.ReadFromUser(message);
        }

        public static uint ReadPositiveInt32(string message)
        {
            return int32Reader.ReadPositiveInt32(message);
        }

        public static uint ReadPositiveNonZeroInt32(string message)
        {
            return int32Reader.ReadPositiveNonZeroInt32(message);
        }

        public static int ReadNonZeroInt32(string message)
        {
            return int32Reader.ReadNonZeroInt32(message);
        }

        public static List<int> ReadInt32List(string message)
        {
            return int32Reader.ReadInt32List(message);
        }
    }
}
