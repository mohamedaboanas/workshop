using System;

namespace HelloWorld
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // any thing private with this method

            Console.WriteLine("Draw the circle");

            // execute the base class method
            base.Draw();
        }
    }
}