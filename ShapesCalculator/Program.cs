// See https://aka.ms/new-console-template for more information
using CalculatorLibrary.Formulas.Shapes;
/*
group WaKoKabaw
Members:
	Sucgang
	Cabaluna
	Evangelista
*/ 

Square.sideLength = 5.0;
Console.WriteLine($"square length side: {Square.sideLength}");
Console.WriteLine($"Area of square: {Square.getArea()}");
Console.WriteLine($"Perimeter of square: {Square.getPerimeter()}");

Circle.radius = 5.0;
Console.WriteLine($"circle radius: {Circle.radius}");
Console.WriteLine($"Area of circle: {Circle.getArea()}");
Console.WriteLine($"Perimeter of circle: {Circle.getPerimeter()}");

Rectangle.height = 5.0;
Rectangle.width = 5.0;
Console.WriteLine($"rectangle height: {Rectangle.height}");
Console.WriteLine($"rectangle width: {Rectangle.width}");
Console.WriteLine($"Area of circle: {Rectangle.getArea()}");
Console.WriteLine($"Perimeter of circle: {Rectangle.getPerimeter()}");