using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPlus.Geometry
{
    public class Square
    {

        /// <summary>
        /// Since a square is equal on all sides, we are able to only take in a single variable, since all are equal
        /// </summary>
        /// <param name="SideA"></param>
        public Square(double SideA) =>
            SideOne = SideA;

        private double SideOne;

        /// <summary>
        /// Get the Perimeter of the Square
        /// </summary>
        /// <returns>Value of Square Perimeter</returns>
        public double Perimeter() { return SideOne * 4; }

        /// <summary>
        /// Gets the Area of the Square
        /// </summary>
        /// <returns>Area of Square</returns>
        public double Area() { return SideOne * SideOne; }

    }
}
