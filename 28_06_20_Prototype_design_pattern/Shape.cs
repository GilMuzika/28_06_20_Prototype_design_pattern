using System;
using System.Collections.Generic;
using System.Text;

namespace _28_06_20_Prototype_design_pattern
{
    public abstract class Shape : ICloneable
    {
        protected int _id;
        protected string _type;

        protected abstract void Draw();

        public string GetMyType()
        {
            return _type;
        }

        public object Clone()
        {
            Object clone = null;
            try
            {
                clone = this.DeepClone();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            return clone;
        }

        public void Setid(int id)
        {
            _id = id;
        }
        public int GetId()
        {
            return _id;
        }
    }
}
