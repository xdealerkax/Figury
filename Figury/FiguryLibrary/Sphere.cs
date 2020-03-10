using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Sphere : Circle,IMeasurable2D // w circle dziedziczy się wszystko oprócz konstruktora
    {
        public Sphere(double r = 1) : base(r) //odwołanie do konstruktora(z klasy nadrzędnej) z cicrle używamy R z niego który był w private set
        {
            
        }

        public override string ToString()
        {
            return $"sphere({R})";
        }

        public override double Surface => 4 * base.Surface; //odwołuje się do tego wzoru ale pisze go wpo swojemu //sfera nie możę dziedziczyć obwodu z kółka
        public override double Perimeter => throw new NotSupportedException("sfera nie ma obwodu");     // skalowanie sfery polega na zwęikszeniu r

        public new Sphere Scale(double factor)  //słowo new piszesz kod od zera poza hierarchia brak dziedziczenia
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException("komunikat");

             return new Sphere(R * factor);
        }
        
        
                                                                                                      
    }

}
