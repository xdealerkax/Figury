using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary; //namespace

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main()
        {
            var t = new Triangle();
            Console.WriteLine(t);
            Console.WriteLine(t.Color);
            t.Print(); // polimorfizm

            var s = new Sphere(10);
            Console.WriteLine(s);
            Console.WriteLine(s.Surface);
<<<<<<< HEAD
            //Console.WriteLine(s.Perimeter);

            var c = new Circle(1);
            var t1 = new Triangle(3, 4, 5);
            var s1 = new Sphere(2);

            // Lista figur to tablica która nie ma końca
            List<Figure> lista; // w <> typ generyczny piszemy czego to jest kolekcja 
            lista = new List<Figure>(); // utworzenie obiektu typu lista
            lista.Add(t);
            lista.Add(s);
            lista.Add(c);
            lista.Add(t1);
            lista.Add(s1);
            lista.Add(new Circle(4)); //dostep do niego tylko z listy

            foreach (var f in lista)
            {
                Console.WriteLine(f); // wypisz figure f
            }

            Console.WriteLine("=====================");
            var total = 0.0;
            foreach ( var f in lista )
            {
                if (f is IMeasurable2D)  // operator is czy f jest typu imeasu..
                {
                    total += ((IMeasurable2D)f).Surface; // rzutowanie f na imeasu..
                    Console.WriteLine(f);
                }
                   

            }
            Console.WriteLine($"Sumaryczne pole = {total}");
=======
            Console.WriteLine(s.Perimeter);
            var t1 = new Triangle();
            Console.WriteLine(t1);
            Console.WriteLine(t1.Surface);
>>>>>>> 0a2d6fa7fa388f0d552f42e3e5778493a2e79bc1

        }

        static void Main2()
        {
            Triangle t = new Triangle();
            Console.WriteLine(t);

            var t1 = new Triangle(1.5, 1, 1);
            Console.WriteLine(t1);
            

            // var t2 = new Triangle(3); // pozostałe boki równe 1 
            // Console.WriteLine(t2);
            var t3 = t1.Scale(2); // t3 dwa razy większy niż t1
            Console.WriteLine(t3);
        }

        static void Main1(string[] args)
        {
            Trojkat t1; // deklaracja zmiennej typu Trojkat
            t1 = new Trojkat(); //tworzenie obiektu (new)

           // Trojkat t2 = new Trojkat(1, 2, 3); // długości boków , a =1
           // var t3 = new Trojkat(c: 1, b: 2, a: 2); // utworz zmienna t3 typu trojkat var jest deklaracja ze używasz zmiennej

            Console.WriteLine(t1); //FiguryLibrary.Trojkat (to wyświetli)
            Console.WriteLine(t1.GetObwod()); //nawiasy bo to funkcja
            Console.WriteLine(t1.Obwod);
            Console.WriteLine($"pole = {t1.GetPole()}");
            Console.WriteLine($"pole = {t1.Pole}"); // nie jest metodą nie ma ()
            try
            {
                t1.A = -1;
                t1.B = -2;
                t1.C = -3;
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Nie wolno bokom przypisywać wartości ujemnych");
            }
            

            //t1.a = 5; // wyświetli NaN not number

            Console.WriteLine(t1);  
            Console.WriteLine(t1.Pole);
            Console.WriteLine("========================");
            var t2 = new Trojkat(3, 4, 5);
            Console.WriteLine(t2);
            // Console.WriteLine(t2.A);
            //Console.WriteLine(t2.Pole);
            Console.WriteLine();

            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

           
        } // wcześniej był main
    }
}
