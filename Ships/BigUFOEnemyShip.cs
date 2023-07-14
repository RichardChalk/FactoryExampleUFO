using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUFO.Ships
{
    class BigUFOEnemyShip : IEnemyShip
    {
        public string Name { get; set; }
        public double AmtDamage { get; set; }
        public int HP { get; set; }


        public BigUFOEnemyShip()
        {
            Name = "Big UFO Enemy Ship";
            AmtDamage = 40.0;
            HP = 100;
        }
        public void FollowHeroShip()
        {
            Console.WriteLine(Name + " Following the Hero Ship");
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine(Name + " is on the screen");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine(Name + " attacks and does " + AmtDamage + " damage");
        }
        public void ShipTakesDamage(int dmg)
        {
            HP -= dmg;
            if (HP <= 0)
                Console.WriteLine(Name + " is dead!");
            else
                Console.WriteLine(Name + " has " + HP + " HP");
        }
    }
}
