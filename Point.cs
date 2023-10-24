using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork4CDSP
{
    public struct Point
    {
        public double X;
        public double Y;
        public double Distance(Point point) => Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));
    }
}
