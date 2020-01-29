using System;

namespace HelloWorld
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int  Height { get; set; }


        public void Copy()
        {
            Console.WriteLine("Message was copied to the clipboard....");
        }

        public void Duplicate()
        {
            Console.WriteLine("Message was duplicated.");
        }
    }
}