using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsForHumans.Factory
{
    //This is the core class that implements the Door Interface and expands upon it's behavior.
    public class WoodenDoor : Door
    {
        protected float Width { get; set; }
        protected float Height { get; set; }

        public WoodenDoor(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public float getWidth()
        {
            return Width;
        }

        public float getHeight()
        {
            return Height;
        }
    }
}
