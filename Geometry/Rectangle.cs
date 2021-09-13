using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPlus.Geometry
{
    public class Rectangle
    {
        /// <summary>
        /// Constructor for Length and Width of Rectangle
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Width"></param>
        public Rectangle(double Length, double Width)
        {
            rect_Length = Length;
            rect_Width = Width;
        }

        private double rect_Length;
        private double rect_Width;

        /// <summary>
        /// Gets Value of Perimeter
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return ((2 * rect_Length) + (2 * rect_Width));
        }

        /// <summary>
        /// Gets Value of Area
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return (rect_Width * rect_Length);
        }
    }
}
