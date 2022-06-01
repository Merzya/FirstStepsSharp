using System;
using System.Text;

namespace Rogalik
{
    internal class Program
    {

        private static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Game game = new Game();
            game.Start();
            
            while (true)
            {
                Console.WriteLine("PLAY AGAIN?");
                var Answer = Console.ReadLine();

                if (Answer is "y" or "yes" or "так")
                {
                    game.Start();
                }
                else
                {
                    break;     
                }
            }
            
        }

    }


}