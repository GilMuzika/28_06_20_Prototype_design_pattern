using System;

namespace _28_06_20_Prototype_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCashe.CreateCashe();

            Shape clonedShape = ShapeCashe.GetShape(1);
            Console.WriteLine($"Shape: {clonedShape.GetMyType()}");

            Shape clonedShape2 = ShapeCashe.GetShape(2);
            Console.WriteLine($"Shape: {clonedShape2.GetMyType()}");

            Shape clonedShape3 = ShapeCashe.GetShape(3);
            Console.WriteLine($"Shape: {clonedShape3.GetMyType()}");


        }
    }
}
