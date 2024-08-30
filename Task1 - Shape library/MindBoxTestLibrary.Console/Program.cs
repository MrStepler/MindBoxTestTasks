using MindBoxTestLibrary;
var triangle1 = new Triangle(3.4d, 3d, 6d);
var triangle2 = new Triangle(3, 4, 5);
IEnumerable<IShapeParameterizable> shapes = [triangle1, new Circle(3) , triangle2];
foreach (var shape in shapes)
{
    Console.WriteLine($"Area: {shape.Area} - Perimeter {shape.Perimeter}");
}
Console.WriteLine($"Is a right triangle 1 : {triangle1.IsRightTriangle}");
Console.WriteLine($"Is a right triangle 2 : {triangle2.IsRightTriangle}");