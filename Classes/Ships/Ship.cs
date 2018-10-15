using Battleships.Classes.Cases;
using System.Collections.Generic;

namespace Battleships.Classes.Ships
{
    public class Ship
    {
        public bool IsVertical { get; private set; } = false;
        public bool IsAlive { get; private set; } = true;
        public string Name { get; private set; }

        public List<ShipCase> Cases = new List<ShipCase>(5);

        public Ship(Ships size)
        {
            Name = size.ToString();
        }
    }
}
