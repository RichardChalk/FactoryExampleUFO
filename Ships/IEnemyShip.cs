using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUFO.Ships
{
    interface IEnemyShip
    {
        string Name { get; set; }
        double AmtDamage { get; set; }
        int HP { get; set; } 


        void FollowHeroShip();
        void DisplayEnemyShip();
        void EnemyShipShoots();
        void ShipTakesDamage(int dmg);

    }
}
