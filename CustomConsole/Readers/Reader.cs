using CustomConsole.Services;
using System;
using System.Collections.Generic;

namespace CustomConsole
{
    public abstract class Reader
    {
        protected string input;

        protected T ValidateInput<T>(string errorMessage, Func<T, bool> criteria = null) where T : struct
        {
            T output = default(T);
            while (!ConversionService.Convert(input, ref output) || ApplyCriteria(output, criteria))
            {
                Console.Write(errorMessage);
                input = Console.ReadLine();
            }
            return output;
        }

        protected List<T> ValidateListOfInputs<T>() where T : struct
        {
            T output = default(T);
            List<T> outputs = new List<T>();
            while (ConversionService.Convert(input, ref output))
            {
                outputs.Add(output);
                input = Console.ReadLine();
            }
            return outputs;
        }

        protected string ReadFirstInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private bool ApplyCriteria<T>(T output, Func<T, bool> criteria) where T : struct
        {
            return criteria != null ? criteria(output) : false;
        }

        public abstract object ReadFromUser(string message);
    }
}
