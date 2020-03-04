using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguryLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod] // test z użyciem danych
        [DataRow(3, 4, 5)] //zestaw testowy myślimy tylko o poprawnych danych
        [DataRow(2, 3, 4)] // zostaną  wykonane 3 testy
        [DataRow(1, 1, 1)]
        //Pierwszy test
        public void ConstructorPoprawneDaneTrojkatUtworzony(double a, double b, double c) // w nazwie testu=procedury powinno sie zawrzeć co testujemy w jakich warunkach(poprawne dane) i jaki wynik(trojkat sie utworzy) 
        {
            //AAA
            //Arange
           // double a = 3;
           // double b = 4; Przez double a (w public void) itp nie potrzeby ten kod
           // double c = 5;

            //Act
            Trojkat t = new Trojkat(a, b, c);

            // Assert
            Assert.AreEqual(a, t.A);   //czy jest równe to co weszło z tym co wyszło czy to co z a jest zapamiętane w A
            Assert.AreEqual(b, t.B);
            Assert.AreEqual(c, t.C);
        }

        [TestMethod] //to nie kod, adnotacja
        public void ConstructorDefaultPoprawnie()
        { 
            //Arrange

            //Act
            Trojkat t = new Trojkat();

            //Assert
            Assert.AreEqual(1, t.A);
            Assert.AreEqual(1, t.B);
            Assert.AreEqual(1, t.C);

        } //test bez zestawu danych

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-1,1,1)]
        [DataRow(1,-1,1)]
        [DataRow(1,1,-1)]
        public void ConstructorUjemnyParametr_ArgumentOutOfRangeException(double a, double b, double c) //Te nazwy to opis dla menadżera frameworka 
        {
            Trojkat t = new Trojkat(a, b, c);
        }


        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(1, 1, 100)]
        [DataRow(100, 1, 1)]
        [DataRow(1, 100, 1)]
        public void ConstructorNieSpelnionyWarunekTrojkata_ArgumentException(double a , double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 3)] // 3 to wynik który weryfikujemy
        [DataRow(3, 4, 5, 12)]
        public void PropertyObwod_Poprawnie(double a, double b, double c, double wynik)
        {
            //Act
            var t = new Trojkat(a, b, c);

            //Assert
            Assert.AreEqual(wynik, t.Obwod, 0.01); // oczekujemy że będzie wynik a otrzymujemy obwod t Czy jest to równe
            // z jaką dokładnością porównujemy, 0.01 do dwoch miejsc po przecinku
        }

        [DataTestMethod]
        [DataRow(3,4,5,6)]
        [DataRow(1, 1 ,1, 0.433012701892219)]
        public void PropertyPole_Poprawnie(double a, double b, double c, double wynik)
        { 
             var t  = new Trojkat(a , b , c);
            Assert.AreEqual(wynik, t.Pole, 0.01);

        }

    }

}
