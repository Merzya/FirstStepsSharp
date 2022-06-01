// See https://aka.ms/new-console-template for more information
namespace Rogalik
{
    public class Field
    {
        private const string EmptyField = "[ ]";

        //private const byte MAP_SIZE = 6;
        private string[,] _fields;
        public Field(byte fieldSize)
        {
            _fields = new string[fieldSize, fieldSize];
            RenderMap (fieldSize);
        }
     
        public string[,] RenderMap(byte fieldSize)
        {
            for (int y = 0; y < fieldSize; y++)
            {
                
                for (int x = 0; x < fieldSize; x++)
                {
                    _fields[x, y] = EmptyField;
                }
               
            }
            return _fields;
        }

        public string[,]  GetMap()
        {
            return _fields;
        }

        public void AddCreature(Creatures creatures)
        {
            Position CreaturePos = creatures.Position;
           
            _fields[CreaturePos.X, CreaturePos.Y] = creatures.Look;
        }
                
        public void DelCreature(Creatures creatures)
        {
            Position CreaturePos = creatures.Position;
            
            _fields[CreaturePos.X, CreaturePos.Y] = EmptyField;
        }
    }
}