using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibrary.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void Area_OnGet_ShouldReturnValidArea()
        {
            var circle = new Circle(5d);
            Assert.Equal(Math.PI * Math.Pow(5d, 2d), circle.Area);
        }

        [Fact]
        public void Perimeter_OnGet_ShouldReturnValidArea()
        {
            var circle = new Circle(5d);
            Assert.Equal(Math.PI * 5d * 2, circle.Perimeter);
        }

        [Fact]
        public void Circles_WithSameRadius_ShouldBeEqual()
        {
            var circle1 = new Circle(5d);
            var circle2 = new Circle(5d);
            Assert.True(circle1.Equals(circle2));

        }

        [Fact]
        public void Circles_WithDifferentRadius_ShouldNotBeEqual()
        {
            var circle1 = new Circle(5d);
            var circle2 = new Circle(6d);
            Assert.False(circle1.Equals(circle2));
        }
    }
}
