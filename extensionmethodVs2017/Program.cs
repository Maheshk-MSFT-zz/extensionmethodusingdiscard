using System;

namespace extensionmethodVs2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var someStringVariable = "100";

            if (someStringVariable.ToInteg())
            {
                global::System.Console.WriteLine("Valid integer");
            }
            else
            {
                global::System.Console.WriteLine("Invalid integer");
            }

            _ = Console.ReadLine();
        }
    }
}
