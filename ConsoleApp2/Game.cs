namespace Rogalik
{
      internal partial class Game
    {
        public const int MAP_SIZE = 6;

        public Game()
        {
        }

        internal void Start()
        {
            Random random = new Random();


            Field map = new(MAP_SIZE);

            Hero hero = new(RandomPosition(random));
            map.AddCreature(hero);

            Moskal moskal = new(RandomPosition(random));
            map.AddCreature(moskal);

            for (int i = 0; i < 4; i++)
            {
                Mine mine = new(RandomPosition(random));
                map.AddCreature(mine);
            }

            for (int i = 0; i < 2; i++)
            {
                Helicopter helicopter = new(RandomPosition(random));
                map.AddCreature(helicopter);
            }

            while (hero.IsAlive && !moskal.IsDead)
            {
               
                Console.Clear();
                PrintMap(map.GetMap());
                
                Console.WriteLine("Hero: " + hero.Position.X + " " + hero.Position.Y);
                Console.WriteLine("moskal: " + moskal.Position.X + " " + moskal.Position.Y);
                if (hero.Position.Equals(moskal.Position))
                {
                    hero.IsAlive = false;
                    break;
                }


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

                string? helicopter = map.GetMap()[hero.Position.X, hero.Position.Y];
                if (helicopter == "[Ж]")
                {
                    
                    hero.Position = new(RandomPosition(random)); 
                }

                string? mine = map.GetMap()[hero.Position.X, hero.Position.Y];
                if (mine == "[O]")
                {
                    hero.IsAlive = false;
                    break;
                }

                map.AddCreature(hero);

                if (hero.Position.Equals(moskal.Position))
                {
                    moskal.IsDead = true;
                    break;
                }

                map.DelCreature(moskal);
                moskal.Run(random.Next(1, 4));
                map.AddCreature(moskal);

                if (consoleKey.Key == ConsoleKey.Escape)
                {
                    break;
                }

            }
            Console.Clear();
            PrintMap(map.GetMap());
            if (hero.IsAlive)
            {
                Console.WriteLine("Перемога!!! Слава Україні");
            }
            if (!moskal.IsDead)
            {
                Console.WriteLine("Зрада!!! Москаляку на гілляку");
            }

        }

        private static Position RandomPosition(Random random)
        {
            return new Position(random.Next(0, MAP_SIZE), random.Next(0, MAP_SIZE));
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