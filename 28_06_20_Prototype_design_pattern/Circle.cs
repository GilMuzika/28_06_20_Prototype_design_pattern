using System;
using System.Collections.Generic;
using System.Text;

namespace _28_06_20_Prototype_design_pattern
{
    public class Circle : Shape
    {
        public Circle()
        {
            _type = "Cyrcle";
        }

        protected override void Draw()
        {
            Console.WriteLine("Inside Circle = Draw() method.");
        }


    }
}
