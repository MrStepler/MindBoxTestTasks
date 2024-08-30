using MindBoxTestLibrary;
namespace MindBoxTestLibrary.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void Area_OnGet_ShouldReturnValidArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6; // Area of a 3-4-5 triangle is 6
            Assert.Equal(expectedArea, triangle.Area);
        }

        [Fact]
        public void Perimeter_OnGet_ShouldReturnValidPerimeter()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedPerimeter = 12; // Perimeter of a 3-4-5 triangle is 12
            Assert.Equal(expectedPerimeter, triangle.Perimeter);
        }

        [Fact]
        public void Right_OnGet_ShouldReturnTrueForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle);
        }

        [Fact]
        public void Right_OnGet_ShouldReturnFalseForNonRightTriangle()
        {
            var triangle = new Triangle(3, 3, 3);
            Assert.False(triangle.IsRightTriangle);
        }

        [Fact]
        public void Triangles_WithSameSidesInDifferentOrder_ShouldBeEqual()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(5, 3, 4);
            Assert.True(triangle1.Equals(triangle2));
        }

        [Fact]
        public void Triangles_WithDifferentSides_ShouldNotBeEqual()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(3, 3, 3);
            Assert.False(triangle1.Equals(triangle2));
        }

    }
}