using System.Collections.Generic;

namespace HelloWorld
{
    public class Canvas
    {
        public void DrawShap(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}