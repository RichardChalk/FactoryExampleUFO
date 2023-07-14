using ExampleUFO.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUFO.Factory
{
    class EnemyShipFactory
    {
        public IEnemyShip MakeEnemyShip(string shipTypeChosen)
        {
            if (shipTypeChosen == "U")
                return new UFOEnemyShip();
            else if (shipTypeChosen == "R")
                return new RocketEnemyShip();
            else if (shipTypeChosen == "B")
                return new BigUFOEnemyShip();
            else if (shipTypeChosen == "BR")
                return new BigRocketEnemyShip();
            else
                return null;
        }
    }
}
