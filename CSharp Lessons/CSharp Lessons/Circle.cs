namespace CSharp_Lessons
{
    using System;

    class Circle
    {
        const double pi = Math.PI;
        double radius;

        public Circle(int r)
        {
            radius = r;
        }

        public double Area()
        {
            double area = pi * radius * radius;
            return area;
        }

        public double Length()
        {
            double length = 2 * pi * radius;
            return length;
        }

        public bool CheckPoint_In(double x, double y)
        {
            if (x * x + y * y > radius * radius) 
            {
                return true;
            }
            return false;
        }
    }
}
