using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibrary
{
    public struct Circle: IShapeParameterizable, IEquatable<Circle>
    {
        public readonly double Radius { get;}
        public double Perimeter { get => 2* Math.PI * Radius; }
        public double Area { get => Math.Pow(Radius, 2) * Math.PI; }
        public Circle(double radius) 
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Invalid parameter value");
            }
            Radius = radius;
        }

        public bool Equals(Circle other)
        {
            if (Radius != other.Radius)
                return false;
            return true;
        }
        public override bool Equals([NotNullWhen(true)] object? obj)=> obj is Circle other && Equals(other);
        public override int GetHashCode()
        {
            return HashCode.Combine(Radius);
        }
    }
}
