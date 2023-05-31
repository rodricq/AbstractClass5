using System;

namespace AbstractClass5
{
   abstract class Motorbike
    {
        public abstract void brake();
    }

    class SportsBike : Motorbike
    {
        //provide implimantation of abstract method
        public override void brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }
    }
    class MountainBike : Motorbike {

        //provide implimantation of abstract method

        public override void brake()
        {
            Console.WriteLine("Mountain Bike Brake");
        }
    }

    class Car : Motorbike
    {

        //provide implimantation of abstract method

        public override void brake()
        {
            Console.WriteLine("Car Brake");
        }
    }

    class SportsCar : Motorbike
    {

        //provide implimantation of abstract method

        public override void brake()
        {
            Console.WriteLine("SportsCar Brake");
        }
    }


    class Program
    {
        static void Main (string [] args)
        {
            //create an object of SportsBike class
            SportsBike s1 = new SportsBike();
            s1.brake();

            //create an object of MountainBike class
            MountainBike m1 = new MountainBike();
            m1.brake();

            //create an object of Car class
            Car c1 = new Car();
            c1.brake();


            //create an object of Car class
            SportsCar sc1 = new SportsCar();
            sc1.brake();

            Console.ReadLine();


        }
    }
}
