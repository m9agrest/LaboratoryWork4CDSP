﻿namespace LaboratoryWork4CDSP
{
    public class Circle : Point
    {
        public double R;
        public Circle(double x, double y, double r) : base(x, y)
        {
            R = r;
        }
        public bool isInside(Point point) => R >= Distance(point);
        public bool isBorder(Point point) => R == Distance(point);
    }
}
