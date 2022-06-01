// See https://aka.ms/new-console-template for more information
namespace Rogalik
{
    public class Moskal : Creatures
    {
        public Moskal(Position position) : base(position, "[M]")
        {
            IsDead = false;
        }
        public bool IsDead { get; set; }

        public void Run( int Direсtion)
        {
            int x = 0;
            int y = 0;
            switch (Direсtion)
            {
                case 1:
                    x = Position.X - 1;
                    y = Position.Y;

                    Position = new Position(x, y);
                    break;

                case  2:
                    x = Position.X;
                    y = Position.Y - 1;

                    Position = new Position(x, y);
                    break;

                case 3:
                    x = Position.X + 1;
                    y = Position.Y;

                    Position = new Position(x, y);
                    break;

                case 4:
                    x = Position.X;
                    y = Position.Y + 1;

                    Position = new Position(x, y);
                    break;
            }
       
        }
    } 
    }