using System;
using System.Collections.Generic;
using System.Text;

namespace _28_06_20_Prototype_design_pattern
{
    public class ShapeCashe
    {
        private static Dictionary<int, Shape> _shapeMap = new Dictionary<int, Shape>();

        public static Shape GetShape(int shapeId)
        {
            bool isGotten = _shapeMap.TryGetValue(shapeId, out Shape cashedShape);

            if (isGotten) return (Shape)cashedShape.Clone();
            else return null;
        }

        public static void CreateCashe()
        {
            Circle circle = new Circle();
            circle.Setid(1);
            _shapeMap.Add(circle.GetId(), circle);

            Square square = new Square();
            square.Setid(2);
            _shapeMap.Add(square.GetId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.Setid(3);
            _shapeMap.Add(rectangle.GetId(), rectangle);
        }


    }
}
