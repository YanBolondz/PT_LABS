// Создание уравнения без корней
using OOP_SAMPLE;

QuadraticEquation eq1 = new QuadraticEquation(2, -4, 3);
eq1.PrintInfo();

QuadraticEquation eq2 = new QuadraticEquation(0, 4, -5);
eq2.PrintInfo();


QuadraticEquation eq3 = new QuadraticEquation(1, 2, 3);
eq3.PrintInfo();
Console.WriteLine(eq3.GetRootsCount());


Console.WriteLine("Get Roots Of Equation 1:");
foreach (double root in eq1.GetRoots())
{
    Console.WriteLine($"Root = {root}");
}

Console.WriteLine("Get Roots Of Equation 2:");
foreach (double root in eq2.GetRoots())
{
    Console.WriteLine($"Root = {root}");
}

Console.WriteLine("Get Roots Of Equation 3:");
foreach (double root in eq3.GetRoots())
{
    Console.WriteLine($"Root = {root}");
}