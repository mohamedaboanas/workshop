using System;

namespace HelloWorld
{
    public class Rectangle : Shape
    {

        private double length;
        private double width;

        public void AccepDetails()
        {
            Console.Write("Enter the length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width: ");
            width = Convert.ToDouble(Console.ReadLine());

        }

        public double GetArea()
        {
            return length * width;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        public override void Draw()
        {
            Console.WriteLine("Draw rectangle..");
        }
    }
}