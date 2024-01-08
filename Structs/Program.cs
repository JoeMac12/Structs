using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {

        // Unity example

    struct vector3
    {
        public float x;
        public float y;
        public float z;
    }
    static void Main(string[] args)
        {
            Console.WriteLine("Struts");
            Console.WriteLine();

            // no structs
            // no classes (objects)

            // player
            int health = 100;
            int shield = 100;
            int score = 0;
            int playerx = 10;
            int playery = 10;

            // 1000 enemys
            int numEnemies = 1000;
            int[] enemyX = new int[numEnemies];
            int[] enemyY = new int[numEnemies];


            Console.WriteLine("Press any key to exit the program");

            Console.ReadKey(true);
        }
    }
}
