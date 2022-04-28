// See https://aka.ms/new-console-template for more information
using System;
namespace consolesapp
{
    class program
    {
    

        static void Main(string[] args)
        {
            ReturnComAge(args);
        }

        private static void ReturnComAge(string[] args)
        {
            if (args.Length != 0)
            {
                int Age = GetIntFromArgs(args[0]);

                string[] status = new string[]
                {"not born",
                 "small",
                 "old",
                };

                if (Age >= 18)
                {
                    Console.WriteLine(status[2]);
                }
                else if (Age is > 0 and < 18)
                {
                    Console.WriteLine(status[1]);
                }
                else
                {
                    Console.WriteLine(status[0]);
                }
            }
           
        }

        private static int GetIntFromArgs(string arg)
        {
            if (int.TryParse(arg, out int value))
            {
                return value;
            }
            else { return 0; }
        }
    }
}

