using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RATIONAL_5
{
    public class Rational
    {
    private int numerator;
    public int Numerator
    {                                      // числитель
    get { return this.numerator; }

    set
     {
                    this.numerator = value;
                    Simplify();
                }

            }

            private int denominator;

            public int Denominator
            {

                get { return this.denominator; }


                set
                {
                    if (value == 0) // условие неравенства нулю
                    {
                        // Остановим работу программы и создадим исключение
                        throw new DivideByZeroException("Знаменатель не может быть равен 0");
                    }
                    // если не попали внутри условия - запиши значение в поле
                    this.denominator = value;
                    Simplify();
                }
            }

            //конструктор класса (вызывается во время создания объекта)
            public Rational(int numerator, int denominator)
            {

                this.numerator = numerator;

                if(denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель НЕ должен быть равен 0");
            }

                this.denominator = denominator;
                Simplify(); // Упрощаем дробь в момент её создания
            }

            //перегруженный конструктор для рациональной дроби со знаменателем 1
            public Rational(int numerator)
            {
                this.numerator = numerator; // обращаемся к полю
                this.denominator = 1;
                Simplify(); // Упрощаем дробь в момент её создания
            }

            //Преобразуем объект в строку для корректного отображения
            public override string ToString()
            {
                return $"Rational: {Numerator} / {Denominator}";
            }

            private static int GCD(int a, int b) // Алгоритм Евклида
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                return a;
            }

           

        public static Rational operator +(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Denominator;

            int newNumerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
      

            return new Rational(newNumerator, newDenominator);
          
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Denominator;

            int newNumerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;

            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Denominator;
            int newNumerator = r1.Numerator * r2.Numerator;
            
            return new Rational(newNumerator, newDenominator);
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            int newDenominator = r1.Denominator * r2.Numerator;

            int newNumerator = r1.Numerator * r2.Denominator;

            return new Rational(newNumerator, newDenominator);
        }

        public static bool operator >(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator;
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            if (ReferenceEquals(r1, r2)) return true;
            if (ReferenceEquals(r1, null) || ReferenceEquals(r2, null)) return false;

            return r1.Numerator * r2.Denominator == r2.Numerator * r1.Denominator;
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }

       

        private void Simplify()   // Для упрощения дроби
            {
                // Если знаменатель < 0 - домнажаем числитель и знаменатель на -1
                // Решаем проблемы 2, 3
                if (denominator < 0)
                {
                    numerator *= -1;
                    denominator *= -1;
                }

                // НОД числителя и знаменателя (передаём модуль для корректности)
                int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));

                // Сокращаем числитель и знаменатель. Решаем проблему 1.
                numerator /= gcd;
                denominator /= gcd;
            }



        




    }
}
