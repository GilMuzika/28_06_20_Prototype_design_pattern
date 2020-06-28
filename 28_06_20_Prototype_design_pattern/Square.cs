using System;
using System.Collections.Generic;
using System.Text;

namespace _28_06_20_Prototype_design_pattern
{
    public class Square : Shape
    {
        public Square()
        {
            _type = "Square";
        }

        protected override void Draw()
        {
            Console.WriteLine("Inside Square - Draw() method.");
        }
    }
}
