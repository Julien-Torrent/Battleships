namespace Battleships.Classes.Cases
{
    public abstract class Case
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool IsPlayable { get; private set; } = true;
    }
}
