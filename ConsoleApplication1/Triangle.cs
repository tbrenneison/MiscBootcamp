using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle
    {
        //fields
        private int side1;
        private int side2;
        private int angle; 

        public int Side1
        {
            get { return this.side1; }
            set { this.side1 = value; }
        }

        public int Side2
        {
            get { return this.side2; }
            set { this.side2 = value; }
        }

        public int Angle
        {
            get { return this.angle; }
            set { this.angle = value; }
        }

        //constructor
        public Triangle(int side1, int side2, int angle)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Angle = angle;
        }

        //method
        public double GetArea()
        {
            double sideone = this.Side1;
            double sidetwo = this.Side2;
            double area;
            area = (sideone * sidetwo);
            double sinAng = (Math.Sin(this.Angle * Math.PI / 180));
            return area * sinAng / 2;
        } 

    }
}
