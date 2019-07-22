using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Triangle : IShape
    {
        double _base, height;
        public Triangle()
        {
            _base = 0.0;
            height = 0.0;
        }
        public Triangle(double _base, double height)
        {
            this._base = _base;
            this.height = height;
        }
        public double CalculateArea()
        {
            return (0.5 * _base * height);
        }
    }
}
