// See https://aka.ms/new-console-template for more information


using OOP_RATIONAL_5;

try
{
     
    Rational r1 = new Rational(1, 2);    
    Rational r2 = new Rational(2, 4);
    Console.WriteLine($"1/2 == 2/4 ? {r1 == r2}"); // True
    Console.WriteLine($"1/2 != 2/4 ? {r1 != r2}"); // False

    
    Rational r3 = new Rational(3, 4);
    Rational r4 = new Rational(2, 3);
    Console.WriteLine($"3/4 > 2/3 ? {r3 > r4}");   // True
    Console.WriteLine($"3/4 < 2/3 ? {r3 < r4}");   // False


    Rational r5 = new Rational(-1, 2);
    Rational r6 = new Rational(1, -2); // упрощается до -1/2
    Console.WriteLine($"-1/2 == 1/-2 ? {r5 == r6}"); // True
    Console.WriteLine($"-1/2 < 0 ? {r5 < new Rational(0, 1)}"); // True

    
    Rational r7 = new Rational(5, 1); // 5
    Rational r8 = new Rational(10, 2); // упрощается до 5
    Console.WriteLine($"5 == 10/2 ? {r7 == r8}"); // True
    Console.WriteLine($"5 > 4 ? {r7 > new Rational(4, 1)}"); // True

}

catch
{
    Console.WriteLine("Ошибка");
}


