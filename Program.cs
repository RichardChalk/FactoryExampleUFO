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
            var ship = Console.ReadLine();

            var myEnemyShipFactory =
               new EnemyShipFactory();
            var theEnemy =
               myEnemyShipFactory.MakeEnemyShip(ship);

            theEnemy.DisplayEnemyShip();
            theEnemy.FollowHeroShip();
            theEnemy.EnemyShipShoots();
            Console.ReadLine();
        }
    }
}
