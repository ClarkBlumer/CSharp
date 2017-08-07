using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Car
    {
        public delegate void CarEventHandler(string msg);
        public event CarEventHandler Exploded;

        bool carIsDead;
        public bool CarIsDead
        {
            get
            {
                return carIsDead;
            }
            set
            {
                carIsDead = value;
            }
        }

        public void SpeedUp(float delta)
        {
            if (carIsDead)
            {
                if(Exploded != null)
                    Exploded("You exploded!"); //publisher
            }
        }
    }
}
