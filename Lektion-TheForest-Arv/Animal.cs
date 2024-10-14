using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_TheForest_Arv
{
    internal class Animal //Basklass
    {
        //I klassen Animal kan vi ha flera klasser i samma namespace
        public int Weight { get; set; }
        public bool Nocturnal { get; set; }

        public Animal(int weight, bool nocturnal) 
        {
            Weight = weight;
            Nocturnal = nocturnal;


        }
        public virtual void Move(bool day)
        {
            //Inget händer
        }

    }

    //Vi har en Uggla men den ärver egenskaper från Animal
    class Owl : Animal
    {
        public int Wingspan { get; set; }

        public Owl(int weight, bool nocturnal, int wingspan) 
            : base (weight, nocturnal)
        {
            Wingspan = wingspan;
        }
        public override void Move(bool day)
        {
            if (Nocturnal == true && day == false)
            {
                Console.WriteLine("Ugglan flyger över träden.\n");
            }
            else
            {
                Console.WriteLine("Ugglan sover på ett träd\n");
            }
        }


    }

    class Horse : Animal // Subklass
    {
        public int HayPerDay { get; set; }
        public Horse(int weight, bool nocturnal, int hayPerDay) :base (weight, nocturnal) 
        {
            HayPerDay = hayPerDay;  
        }

        public override void Move(bool day)
        {
            if (Nocturnal == false && day == true)
            {
                Console.WriteLine("Hästen galopperar.\n");
            }
            else
            {
                Console.WriteLine("Hästen sover under ett träd. \n");
            }
        }
    }

    class Dolphin : Animal
    {
        public int DistancePerDay { get; set; }
        public Dolphin(int weight, bool nocturnal, int distancePerDay) : base (weight, nocturnal) 
        {
            DistancePerDay = distancePerDay;
        }
        public override void Move(bool day)
        {
            if (Nocturnal == false && day == true)
            {
                Console.WriteLine("Dolfinen simmar.\n");
            }
            else
            {
                Console.WriteLine("Dolfinen sover i havet\n");
            }
        }
    }
}
