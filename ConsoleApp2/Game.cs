namespace Rogalik
{
    internal partial class Game
    {
        public Game()
        {
        }



        internal void Start()
        {
            Field map = new(6);
            Hero hero = new(new Position(2, 4));
            Moskal moskal = new(new Position(5, 3));

            for (int i = 0; i < 2; i++)
            {
                Mine mine = new(new Position(i + 2, i + 1));
                map.AddCreature(mine);
            }

            for (int i = 0; i < 2; i++)
            {
                Helicopter helicopter = new(new Position(i + 1, i + i));
                map.AddCreature(helicopter);
            }
            map.AddCreature(hero);
            map.AddCreature(moskal);

            
            while (hero.IsAlive && !moskal.IsDead)
            {
                Console.Clear();
                PrintMap(map.GetMap());
                ConsoleKeyInfo consoleKey = Console.ReadKey(true);
                
                map.DelCreature(hero);
                switch (consoleKey.Key)
               
                {
                    case ConsoleKey.LeftArrow:
                        hero.Move(Arrows.Left);
                        break;
                    
                    case ConsoleKey.UpArrow:
                        hero.Move(Arrows.Up);
                        break;
                    
                    case ConsoleKey.RightArrow:
                        hero.Move(Arrows.Right);
                        break;
                   
                    case ConsoleKey.DownArrow:
                        hero.Move(arrrow: Arrows.Down);
                        break;
                    
                    default:
                        break;
                }
                map.AddCreature(hero);
               
                if (consoleKey.Key == ConsoleKey.Escape)
                {
                    break;
                }

            }

            if (hero.IsAlive)
            {
                Console.WriteLine("Перемога!!! Слава Україні");
            }
            if (moskal.IsDead)
            {
                Console.WriteLine("Зрада!!! Москаляку на гілляку");
            }
        }

        private void PrintMap(string[,] fields)
        {
            for (int y = 0; y < fields.GetLength(0); y++)
            {

                for (int x = 0; x < fields.GetLength(1); x++)
                {
                    Console.Write(fields[x, y]);
                }
                Console.WriteLine();
            }

        }
    }
}