using System;
using System.Collections.Generic;
using System.Text;

namespace _28_06_20_Prototype_design_pattern
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            _type = "Rectangle";
        }

        protected override void Draw()
        {
            Console.WriteLine("Inside Rectangle - Draw() method");
        }

    }
}
