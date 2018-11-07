using System.Collections.Generic;
using System;

namespace Overirde
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(); 
            }
        }
    }
}
