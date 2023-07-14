using ExampleUFO.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a kind of enemy.");
            Console.WriteLine("U: UFO");
            Console.WriteLine("R: Rocket");
            Console.WriteLine("B: Big UFO");
            Console.WriteLine("BR: Big Rocket");
            var ship = Console.ReadLine().ToUpper();

            var myEnemyShipFactory =
               new EnemyShipFactory();
            var theEnemy =
               myEnemyShipFactory.MakeEnemyShip(ship);

            theEnemy.DisplayEnemyShip();
            theEnemy.FollowHeroShip();
            theEnemy.EnemyShipShoots();
            
            // Damage ship
            theEnemy.ShipTakesDamage(10);
            // Destroy Small ship
            //theEnemy.ShipTakesDamage(101);
            
            Console.ReadLine();
        }
    }
}
