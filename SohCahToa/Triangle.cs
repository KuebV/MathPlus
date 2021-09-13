using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPlus.SohCahToa
{
    public class Triangle
    {
        /// <summary>
        /// Define the SohCahToa Class and define the Type you are looking for,
        /// Example A:
        /// Looking for Tangent
        /// Pre-Define the SohCahToa Class
        /// Find the SCT_Type you are looking for
        /// In this case, we want Tan
        /// </summary>
        /// <param name="sohCahToa"></param>
        /// <param name="type"></param>
        public Triangle(SohCahToa sohCahToa, SCT_Type type)
        {
            Opposite = sohCahToa.Opposite;
            if (double.IsNaN(Opposite))
                Opposite = -1;

            Adjacent = sohCahToa.Adjacent;
            if (double.IsNaN(Adjacent))
                Adjacent = -1;

            Hypotnuse = sohCahToa.Hypotnuse;
            if (double.IsNaN(Hypotnuse))
                Hypotnuse = -1;

            switch (type)
            {
                case SCT_Type.Sin:
                    if (Opposite == -1 || Hypotnuse == -1)
                        Console.WriteLine("Missing Opposite or Hypotnuse Values for Type Sin");
            }
        }

        public double FindMissingAngle()
        {
        }

        private double Opposite;
        private double Adjacent;
        private double Hypotnuse;
        private SCT_Type LookingForType;
    }

    public class SohCahToa
    {
        public double Opposite { get; set; }
        public double Adjacent { get; set; }
        public double Hypotnuse { get; set; }
  
    }

    public enum SCT_Type
    {
        Sin = 0,
        Cos = 1,
        Tan = 2,
        Sin_Invert = 3,
        Cos_Invert = 4,
        Tan_Invert = 5
    }
}
