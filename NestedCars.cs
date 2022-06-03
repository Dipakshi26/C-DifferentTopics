using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsHandsOn
{
        public class NestedCars
        {

            public void displayCar()
            {
                Console.WriteLine("Car: Bugatti");
            }

            // inner class
            public class Engines
            {
                public void displayEngine()
                {
                    Console.WriteLine("Engine: PetrolEngine");
                }
            }
        }
 }
