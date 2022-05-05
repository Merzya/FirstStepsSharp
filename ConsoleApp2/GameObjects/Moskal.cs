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
    }
}