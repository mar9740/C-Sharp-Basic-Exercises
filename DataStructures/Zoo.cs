using System;

namespace DataStructures
{
    class Zoo
    {

        static void Main(string[] args)
        {
            Mammal[] zooAnimals = new Mammal[5];

            zooAnimals[0] = new Tiger(11, true, "Tony");
            zooAnimals[1] = new Mammal();
            zooAnimals[2] = new Mammal();
            zooAnimals[3] = new Mammal();
            zooAnimals[4] = new Mammal();



            Zoo.printZoo(zooAnimals);
        }

        public static void printZoo(Mammal[] animals)
        {
            foreach(Mammal m in animals)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}
