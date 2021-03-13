using System;
using System.ComponentModel;

namespace CustomConsole.Services
{
    public static class ConversionService
    {
        public static bool Convert<T>(string input, ref T output)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    output = (T)converter.ConvertFromString(input);
                    return true;
                }
                return false;
            }
            catch (NotSupportedException)
            {
                return false;
            }
        }
    }
}
