﻿using System;

namespace HelloWorld
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialize.");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialize. {0}", registrationNumber);
        }
    }
}