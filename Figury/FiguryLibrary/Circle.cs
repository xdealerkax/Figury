using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Circle : Figure, IMeasurable1D,IMeasurable2D // i implementuje z imeassurable2D
    {
        public double R { get; private set; }

        public Circle(double r = 1)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException("R musi być dodatnie");
            R = r;
        }
        public virtual double Perimeter => 2 * Math.PI * R;  // obwód tylko w klasie kółka dla innych klas zły jest dla nich nieodpowiedni

        public virtual double Surface => Math.PI * R * R;

        public double Length => Perimeter; // pytasz o długość odsyłam cię do perimeter

        public override string ToString()
        {
            return $"circle ({R})";
        }

        public Circle Scale(double factor)
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException("wsp. musi być dodatni");

            return new Circle(R * factor);
        }

        public override void Draw()
        {
            Console.WriteLine("rysowanie kółka");
        }
    }
}

               

     
    


    

                        
                        
                            
                         



    
             





