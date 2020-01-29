using System;

namespace HelloWorld
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            // any thing private with this method

            Console.WriteLine("Draw the Traingle");

            // execute the base class method

            base.Draw();
        }
    }
}