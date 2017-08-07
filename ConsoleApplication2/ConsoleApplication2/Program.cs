using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Exploded += CarExploded;
            myCar.SpeedUp(50);
            myCar.CarIsDead = true;
            myCar.SpeedUp(70);
        }

        public static void CarExploded(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
