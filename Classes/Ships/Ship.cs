using Battleships.Classes.Cases;
using System.Collections.Generic;
using System.Linq;

namespace Battleships.Classes.Ships
{
    public class Ship
    {
        public bool IsVertical { get; private set; } = false;
        public bool IsAlive { get; private set; } = true;
        public string Name { get; private set; }

        private List<ShipCase> Cases;

        public Ship(Ships size)
        {
            Cases = new List<ShipCase>((int)size);
            Name = size.ToString();
        }

        public bool IsInside(ShipCase c)
        {
            return Cases.Where(a => a.X == c.X && a.Y == c.Y).Count() > 0;
        }

        public void Hit(ShipCase c)
        {
            Cases.Where(a => a.X == c.X && a.Y == c.Y).FirstOrDefault().IsTouched = true;

            if (Cases.Where(x => x.IsTouched == false).Count() == 0)
            {
                IsAlive = false;
                NotificationCenter.NotificationCenter.Notify(NotificationConstants.Death, this);
            }
        }
    }
}

