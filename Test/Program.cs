using Geometry;
using System;

try
{
    int r = Int32.Parse(Console.ReadLine());
    var areaC = Area.Circle(r);
    Console.WriteLine(areaC);
}
catch { }
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());
var areaT = Area.Triangle(a,b,c);
Console.WriteLine(areaT);
Console.ReadLine();
