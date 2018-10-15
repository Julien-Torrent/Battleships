namespace Battleships.Classes.Cases
{
    public abstract class Case
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public bool IsPlayable { get; private set; } = true;
    }
}
