using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibrary
{
    public struct Triangle : IShapeParameterizable, IEquatable<Triangle>
    {
        /// <summary>
        /// Largest side
        /// </summary>
        public readonly double ASideSize { get;}
        /// <summary>
        /// Medium side
        /// </summary>
        public readonly double BSideSize { get;}
        /// <summary>
        /// Smallest side
        /// </summary>
        public readonly double CSideSize { get;}

        public readonly double Area { get { var p = Perimeter / 2; return Math.Sqrt(p * (p - ASideSize) * (p - BSideSize) * (p - CSideSize)); } }

        public readonly double Perimeter { get => ASideSize + BSideSize + CSideSize; }
        public Triangle(double side1, double side2, double side3)
        {
            double[] SidesGrade = [side1, side2, side3];
            SidesGrade = [.. SidesGrade.OrderByDescending(x=> x)];
            foreach (var side in SidesGrade)
            {
                if (side <= 0)
                    throw new ArgumentException("Invalid parameter value");
            }
            if (SidesGrade[0] >= SidesGrade[1] + SidesGrade[2])
                throw new ArgumentException("Invalid parameter value");
            ASideSize = SidesGrade[0];
            BSideSize = SidesGrade[1];
            CSideSize = SidesGrade[2];
        }
        public readonly bool IsRightTriangle
        {
            get => Math.Pow(ASideSize, 2d) == Math.Pow(BSideSize, 2d) + Math.Pow(CSideSize, 2d);
        }

        public bool Equals(Triangle other)
        {
            if(ASideSize != other.ASideSize)
                return false;
            if (BSideSize != other.BSideSize)
                return false;
            if (CSideSize != other.CSideSize)
                return false;
            return true;
        }
        public override bool Equals([NotNullWhen(true)] object? obj) => obj is Triangle other && Equals(other);

        public override int GetHashCode()
        {
            return HashCode.Combine(ASideSize, BSideSize, CSideSize);
        }
    }
}
