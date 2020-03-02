﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary; //namespace

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat t1; // deklaracja zmiennej typu Trojkat
            t1 = new Trojkat(); //tworzenie obeiktu (new)

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
            var t2 = new Trojkat(-1, 2, 1);
            Console.WriteLine(t2);
            Console.WriteLine(t2.A);

            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

           
        }
    }
}