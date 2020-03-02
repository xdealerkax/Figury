using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        // 1.dane obiektu - pola obiektu (fields)
         private double a; //this.a formalna nazwa
         public double A // działa jak filtr jest jak opakowanie property hermetyczne dane
        {
            get { return a; } // odczyt wartości
            set 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Wartość A musi być dodatnia"); //wyjątek jesy obiektem
                else
                    a = value;
            } 
           
        }
        private double b; //this.b
        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Wartość B musi być dodatnia"); 
                else
                    b = value;
            }
        }
        private double c; //this.c
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Wartość C musi być dodatnia");
                else
                    c = value;
            }
        }



        // 2.konstruktory opisanie obiektu jest publiczny musi sie nazywać jak nazwa klasy, konstruktor nic nie zwraca

        public Trojkat() // konstruktor domyślny, bez argumentow
        {
            a = b = c = 1.0;
        }
        public Trojkat(double a, double b, double c) // tu są parametry
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Nie spełniony warunek trójkąta");
            }

            this.A = a;
            this.B = b;
            this.C = c;
        }

        // tekstowa reprezentacja obiektu
        public override string ToString() // do stringa nawiasy mówią że to metoda
        {
            return $"Trójkąt(a: {a}, b: {b}, c: {c})";
        }

        // właściwości i metody np obwód
        public double GetObwod() // metoda zwracająca obwód tego trójkąta !!JavaStyle
        {
            return a + b + c;
        }

        // property(właściwości) zwracające obwód tego trójkąta
        public double Obwod => a + b + c; // c# sty;e

        // wzór herona
        public double GetPole() //JavaStyle
        {
            var p = 0.5 * GetObwod();
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));  //pierwiastek kwadratowy
            return s;
        }

         public double Pole //c# style
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }

    }
}
