using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }

        public double GetCircumference()
        {
            //C=2πr
            double Circumference = 2*Math.PI*radius;
            Console.WriteLine("Circumference: " + Circumference);
            return Circumference;



        }

        public double GetArea()
        {
            //A=πr2
            double Area = Math.PI * radius * radius;
            Console.WriteLine("Area: " + Area);
            return Area;
        }

       

    }
}
