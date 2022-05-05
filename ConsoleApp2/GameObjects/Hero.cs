// See https://aka.ms/new-console-template for more information
namespace Rogalik
{
    public class Hero : Creatures
    {
        public Hero(Position position) : base(position, "[@]") 
        {
            IsAlive = true;
        }
        public bool IsAlive { get; set; }
    
        public void Move(Arrows arrrow)
        {
            int x = 0;
            int y = 0;
            switch (arrrow)
            {
                case Arrows.Left:
                     x = Position.X - 1;
                     y = Position.Y;

                    Position = new Position(x, y);
                    break;

                case Arrows.Up:
                    x = Position.X;
                    y = Position.Y - 1;

                    Position = new Position(x, y);
                    break;

                case Arrows.Right:
                    x = Position.X + 1;
                    y = Position.Y;

                    Position = new Position(x, y);
                    break;

                case Arrows.Down:
                    x = Position.X;
                    y = Position.Y + 1;

                    Position = new Position(x, y);
                    break;

            }
        }

    }
}