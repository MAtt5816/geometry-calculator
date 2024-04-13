Console.WriteLine("Welcome in GeometryCalculator example!");

#region Ellipsoid

Console.WriteLine("\nEllipsoid:");
double a, b, c;

#region Volume

a = 3;
b = 2;
c = 1.5;
var volume = GeometryCalculator.Ellipsoid.volume(a, b, c);
Console.WriteLine($"Volume for a={a}, b={b}, c={c}: {volume}");

a = 3;
b = 1.5;
c = 1.5;
volume = GeometryCalculator.Ellipsoid.volume(a, b, c);
Console.WriteLine($"Volume for a={a}, b={b}, c={c}: {volume}");

// Sphere with radius = 2
a = 2;
b = 2;
c = 2;
volume = GeometryCalculator.Ellipsoid.volume(a, b, c);
Console.WriteLine($"Volume for a={a}, b={b}, c={c}: {volume}");

#endregion

#region Area

a = 3;
b = 2;
c = 1.5;
var area = GeometryCalculator.Ellipsoid.area(a, b, c);
Console.WriteLine($"Area for a={a}, b={b}, c={c}: {area}");

a = 3;
b = 1.5;
c = 1.5;
area = GeometryCalculator.Ellipsoid.area(a, b, c);
Console.WriteLine($"Area for a={a}, b={b}, c={c}: {area}");

// Sphere with radius = 2
a = 2;
b = 2;
c = 2;
area = GeometryCalculator.Ellipsoid.area(a, b, c);
Console.WriteLine($"Area for a={a}, b={b}, c={c}: {area}");

#endregion

#endregion