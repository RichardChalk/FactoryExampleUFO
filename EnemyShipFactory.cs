using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUFO
{
    class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string shipTypeChosen)
        {
            if (shipTypeChosen == "U")
                return new UFOEnemyShip();
            else if (shipTypeChosen == "R")
                return new RocketEnemyShip();
            else
                return null;
        }
    }
}
