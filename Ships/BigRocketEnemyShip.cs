using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUFO.Ships
{
    class BigRocketEnemyShip : IEnemyShip
    {
        public string Name { get; set; }
        public double AmtDamage { get; set; }
        public int HP { get; set; }


        public BigRocketEnemyShip()
        {
            Name = "Big Rocket Enemy Ship";
            AmtDamage = 10.0;
            HP = 200;
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
