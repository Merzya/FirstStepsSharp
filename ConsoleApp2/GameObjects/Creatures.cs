// See https://aka.ms/new-console-template for more information
namespace Rogalik
{
    public abstract class Creatures
    {
        protected Creatures(Position position, string look)
        {
            Position = position;
            Look = look;
        }

        public Position Position { get; set;}
        public string Look { get; private set; }
    }

}