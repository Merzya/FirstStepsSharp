// See https://aka.ms/new-console-template for more information
namespace Rogalik
{
    public struct Position
    {
        public Position(int x, int y)
        {
            X = 0;
            Y = 0;
            X = SetPositionOnField(x);
            Y = SetPositionOnField(y);
        }

        public Position(Position position)
        {
            X = 0;
            Y = 0;
            X = SetPositionOnField(position.X);
            Y = SetPositionOnField(position.Y);
        }

        private int SetPositionOnField(int pos)
        {
            int maxvalue = Game.MAP_SIZE - 1;
            if (pos > maxvalue)
            {
                pos = pos - maxvalue - 1;
            }
            if (pos < 0)
            {
                pos = pos + maxvalue + 1;
            }
            return pos;
        }

        public int X { get; }
        public int Y { get; }


    }


}