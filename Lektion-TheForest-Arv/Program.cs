namespace Lektion_TheForest_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Forest \nTryck på d för dag n för natt!");
            List<Animal> forrest = new List<Animal>();

            //Vi har en lista med djur i skogen
            forrest.Add(new Owl(3500, true, 94));
            forrest.Add(new Horse(1200, false, 30));
            forrest.Add(new Dolphin(100000, false, 3750));
            forrest.Add(new Owl(4500, true, 89));
            forrest.Add(new Dolphin(4500, false, 6000));
            forrest.Add(new Horse(5000, false, 400));

            //Vi kan skapa en ny animal men vi vet inte vilken typ av animal detta är.
            //forrest.Add(new Animal(12300, false));

            //Men på sättet nedan kan vi lättare skapa ny animal.
            //List<Owl> OwlsInForest = new List<Owl>();
            //OwlsInForest.Add(new Owl(3500, true, 94));

            //Traditionella sättet att skapa en objekt
            //Owl owl1 = new Owl(3500, true, 94);



            bool day = true;
            while (true)
            {
                string key = Console.ReadKey().Key.ToString();

                Console.Clear();
                

                // Console.WriteLine(key);
                switch (key)
                {
                    case "D":
                        day = true;
                        Console.WriteLine("Nu är det dag!");
                        break;
                    case "N":
                        day = false;
                        Console.WriteLine("Nu är det natt!");
                        break;

                }

                foreach (Animal animal in forrest)
                {
                    Console.Write(animal.GetType().Name + (" Vikt " + animal.Weight + " nattdjur: " + animal.Nocturnal));
                    if (animal is Owl)
                    {
                        Console.WriteLine(" Wingspan: " + ((Owl)animal).Wingspan);
                    }
                    if (animal is Horse)
                    {
                        Console.WriteLine(" Hay per day: " + ((Horse)animal).HayPerDay);
                    }
                    if (animal is Dolphin) // Detta är samma som --> if (animal is Dolphin) = (Dolphin)animlal;
                                           //Console.WriteLine(" Distance per day: " + dolphin.DistancePerDay);
                    {
                        Console.WriteLine(" Distans per day: " + ((Dolphin)animal).DistancePerDay);
                    }

                    animal.Move(day);
                }
                

            }
            
        }
    }
}
