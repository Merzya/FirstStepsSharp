// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace consolesapp
{
    class Program
    {


        static void Main(string[] args)
        {
            if (ReturnComAge(args))
            {
                Console.WriteLine("PlayBlackJack");
                PlayBlackJack();
            } ;
        }

        private static void PlayBlackJack()
        {
            int[] koloda = { 1, 2, 3, 4, 5 };
            int[] MixKoloda = (int[])Mix(koloda);
            
            bool youContinue = true;
            bool compContinue = true;
            Random YesNO = new();

            do
            {
                youContinue = AskYou(youContinue);
                compContinue = AskComp(compContinue, YesNO);
            } while (youContinue || compContinue);
        }

        private static Array Mix(int[] koloda)
        {
            int[] kolodaM = new int[koloda.Length];
            int[] vs = new int[kolodaM.Length];
            koloda.CopyTo(kolodaM, 0);
            
            Random random = new Random();
            int j = 0;
            do
            {
                int Index = random.Next(0, kolodaM.Length);

                if (j == kolodaM.Length)
                {
                    j = 0;
                    continue;
                }
                if ( kolodaM[Index] == 0)
                {
                    continue;
                }

                vs[j++] = kolodaM[Index];
                kolodaM[Index] = 0;
                
                if (kolodaM.Sum() == 0)
                {
                    break;
                }
            } while (0 == 0);
            
            //for (int i = 0; i < vs.Length; i++)
            //{
            //    Console.WriteLine("vs  " + vs[i]);
            //}
            //Console.WriteLine("  " );
            return vs;
        }

        private static bool AskComp(bool compContinue, Random yesNO)
        {
            if (compContinue)
            {
                int decision = yesNO.Next(0, 2);

                if (decision == 0)
            {
                Console.WriteLine("Комп потягнув карту");

                }
                if (decision == 1)
            {
                Console.WriteLine("Комп зпасував");
                compContinue = false;
            }
            }
            return compContinue;
        }

        private static bool AskYou(bool youContinue)
        {
            if (youContinue)
            {

            Console.WriteLine("Тягнутимеш карту? (Т)ак/(Н)і");
            string ans = Console.ReadLine();
            if (ans is "т" or "так")
            {
                Console.WriteLine("Ти потягнув карту");
            }

            if (ans is "н" or "ні")
            {
                Console.WriteLine("Ти зпасував"); 
                youContinue = false;
            }

            }
            return youContinue;
        }

        private static bool ReturnComAge(string[] args)
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
                    return true;
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
           return false;
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

