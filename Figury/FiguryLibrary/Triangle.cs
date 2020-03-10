using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    /// <summary>
    /// Trójkąt w wersji immutable(niezmiennicza) , stan obiektu nigdy nie ulegnie zmianie
    /// </summary>

    public class Triangle : Figure, IMeasurable2D
    {
        public double A { get; private set; } // public a private set A jest read only Można tylko czytać A
        public double B { get; private set; }
        public double C { get; private set; }

        //konstruktor taka sama nazywa jak klasy
        public Triangle(double a = 1, double b = 1, double c = 1) // bez argumentow przypisza 1
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Boki powinny być dodatnie");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Nie spełniony warunek trójkąta");
            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
        {
            return $"triangle({A}, {B}, {C})";
        }

        public double Perimeter => A + B + C;  // obwód

        public double Surface
        {
            get 
            {
                var p = 0.5 * Perimeter;
                var s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                return s;
            }
        }

        public Triangle Scale(double factor) //nie możemy skalować bo obiekt niezmienniczy // produkuje nowy obiekt factor współczynik np 2 (daj mi trójkąt dwa razy większy)
        {                                   // zwraca nam wartość 
            if (factor <= 0)
                throw new ArgumentOutOfRangeException("Współczynnik skalowania musi być dodatni");

            return new Triangle(A * factor, B * factor, C * factor);
        }

        public override void Draw()
        {
            Console.WriteLine("rysowanie trojkata");
        }
    }
}
