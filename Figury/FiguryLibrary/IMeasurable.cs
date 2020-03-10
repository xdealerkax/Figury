using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public interface IMeasurable
    {
        //Współczynnik musi być większy od zera
        //void Skaluj(double wsp); //wsp współczynik 


    }

    public interface IMeasurable1D : IMeasurable
    { 
        double Length { get; }   //figura w 1D obw = długość
    }

    public interface IMeasurable2D : IMeasurable
    {
        double Surface { get; }  // wew nie może być słowa public
        double Perimeter { get; } //property
    }

    public interface IMeasurable3D : IMeasurable
    {
        double Volume { get; } // zwraca double
    }
}
