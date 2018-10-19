using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    // I use a struct here to hold the values for an individual rectangle.
    public struct Rectangle
    {
        public int x { get; }
        public int y { get; }
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.Width = w;
            this.Height = h;
        }
    }

    // Write a function that gives the area of overlap between any rectangles located
    // on an x,y grid.

    public class RectangleOverlap
    {
        public int FindOverlapArea(Rectangle rect1, Rectangle rect2)
        {
            int width = rect1.Width < rect2.Width ? FindOverlap(rect1.x, rect1.Width, rect2.x, rect2.Width)
                : FindOverlap(rect2.x, rect2.Width, rect1.x, rect1.Width);

            int height = rect1.Height < rect2.Height ? FindOverlap(rect1.y, rect1.Height, rect2.y, rect2.Height)
                : FindOverlap(rect2.y, rect2.Height, rect1.y, rect1.Height);

            // If the product of width and height is positive, return the value.
            // If the product is zero or negative, this means that the rectangles
            // not overlap.
            return width * height > 0 ? width * height : 0;
        }

        public int FindOverlap(int coord1, int distance1, int coord2, int distance2)
        {
            // set the width/heoght to the smaller value, since this is the largest
            // possible value for overlap.
            int overlap = distance1;

            // if the far edge of the narrower of the rectangles extends
            // past the other rectangle's far edge, subtract the distance
            // between the two edges.
            overlap -= coord1 + distance1 > coord2 + distance2 ? distance1 + coord1 - (distance2 - coord2) : 0;

            // if the near edge of the wider rectangle extends past the 
            // near edge of the narrow rectangle, then subtract the distance
            // between the two.
            overlap -= coord1 < coord2 ? coord2 - coord1 : 0;

            return overlap;
        }
    }
}
