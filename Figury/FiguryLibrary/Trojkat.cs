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
                else if (isSpelnionyWarunekTrojkata(value, b, c))
                    a = value;
                else // nie jest spełniony warunek trójkąta
                    throw new ArgumentException("Nie spełniony warunek trójkąta przy próbie zmiany A");
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
                else if (isSpelnionyWarunekTrojkata(a, value, c))
                    b = value;
                else // nie jest spełniony warunek trójkąta
                    throw new ArgumentException("Nie spełniony warunek trójkąta przy próbie zmiany B");
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
                else if (isSpelnionyWarunekTrojkata(a, b, value))
                    c = value;
                else // nie jest spełniony warunek trójkąta
                    throw new ArgumentException("Nie spełniony warunek trójkąta przy próbie zmiany C");
            }
        }
        private bool isSpelnionyWarunekTrojkata(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        // 2.konstruktory opisanie obiektu jest publiczny musi sie nazywać jak nazwa klasy, konstruktor nic nie zwraca

        public Trojkat() // konstruktor domyślny, bez argumentow ,pusty
        {
            a = b = c = 1.0;
        }
        public Trojkat(double a, double b, double c) // tu są parametry , konstruktor napisany od nowa
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Boki muszą być dodatnie");

            if (!isSpelnionyWarunekTrojkata(a, b, c))
            throw new ArgumentException("Nie spełniony warunek trójkąta");

            this.a = a; //private double pracujemy an surowych danych
            this.b = b;
            this.c = c;
            
        }

        // tekstowa reprezentacja obiektu jakie dane będą wypisane ,
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
