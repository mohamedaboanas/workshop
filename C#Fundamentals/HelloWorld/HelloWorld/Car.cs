using System;

namespace HelloWorld
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Care is deing initialize. {0}", registrationNumber);
        }
    }
}