using System;
using System.Threading;

namespace ClassObject
{
    class Animal                            // base class (parent)
    {
        // fields                           // Eigenschaften/Attribute
        public int age;                     // Alter
        public string name;                 // Name

        // methods                          // Methoden/Funktionen
        public void sleep()                 // schlafen
        {
            Thread.Sleep(1000);
            Console.WriteLine("*schlafen*");
        }
        public void eat()                   // essen
        {
            // your code                    // dein Programmcode
        }
    }


    class Dog : Animal                      // derived class (child)
    {
        // fields                           // Eigenschaften/Attribute
        public string breed;                // Rasse

        // methods                          // Methoden/Funktionen
        public void bark()                  // bellen
        {
            Console.WriteLine("Wuff");      // dein Programmcode
        }
    }

    class Elephant : Animal                 // derived class (child)
    {
        // fields                           // Eigenschaften/Attribute
        public int weight;                  // Gewicht

        // methods                          // Methoden/Funktionen
        public void trumpet()               // trompeten
        {
            Console.WriteLine("Töröö!");
        }
    }


    class Program
    {
        /// <summary>
        /// Beispielprogramm zu Vererbung (Inheritance)
        /// </summary>
        static void Main(string[] args)     // Hauptprogramm
        {
            // create Animal object                 // Tier-Objekt erzeugen (erstes)
            Animal myFirstAnimal = new Animal();    // meinErstesTier

            // set name of Animal           // Name des Tiers festlegen (tierspezifische Eigenschaft/Attribut)
            myFirstAnimal.name = "Ada";     // string

            // access method of animal      // Zugriff auf Methode von Tieren
            myFirstAnimal.sleep();          // Tier schläft (tierspezifische Methode/Funktion)
                                            // Tier kann keinen Tierlaut machen, da das eine ausschliesslich hunde- bzw. elefantenspezifische Methode/Funktion

            // get name of dog              // Name des Hundes abfragen
            Console.WriteLine(myFirstAnimal.name);

            /*
            etc.
            etc.
            etc.
             */

            #region Zeile Abstsand in der Konsole
            Console.WriteLine(Environment.NewLine);
            #endregion

            // create Dog object            // Hund-Objekt erzeugen (erstes)
            Dog myFirstDog = new Dog();     // meinErsterHund

            // set name of dog              // Name des Hundes festlegen (nicht hundespezifische Eigenschaft/Attribut)
            myFirstDog.name = "Hektor";     // string

            // set age of dog               // Alter des Hundes festlegen (nicht hundespezifische Eigenschaft/Attribut)
            myFirstDog.age = 13;            // integer

            // set breed of dog             // Rasse des Hundes festlegen (hundespezifische Eigenschaft/Attribut)
            myFirstDog.breed = "Dalmatian"; // string

            // access method of dog         // Zugriff auf Methode von Hunden
            myFirstDog.sleep();             // Hund schläft (nicht hundespezifische Methode/Funktion)
            myFirstDog.bark();              // Hund bellt (hundespezifische Methode/Funktion)

            // get name of dog              // Name des Hundes abfragen
            Console.WriteLine(myFirstDog.name);


            // create Dog object            // Hund-Objekt erzeugen (zweites)
            Dog mySecondDog = new Dog();    // meinZweiterHund

            // set breed of dog             // Rasse des Hundes festlegen
            mySecondDog.breed = "Poodle";   // string

            /*
            etc.
            etc.
            etc.
             */

            #region Zeile Abstsand in der Konsole
            Console.WriteLine(Environment.NewLine);
            #endregion

            Elephant myFirstElephant = new Elephant();      // Elefant-Objekt erzeugen (erstes)

            // set name of elephant                         // Name des Elefantes festlegen (nicht elefantspezifische Eigenschaft/Attribut)
            myFirstElephant.name = "Benjamin Blümchen";     // string

            // set weight of elephant                       // Gewicht des Elefantes (elefantspezifische Eigenschaft/Attribut)
            myFirstElephant.weight = 6000;                  // integer

            // access method of elephant                    // Zugriff auf Methode von Elefanten 
            myFirstElephant.sleep();                        // Elefant schläft (nicht elefantspezifische Methode/Funktion)
            myFirstElephant.trumpet();                      // Elefant trompeteter (elefantspezifische Methode/Funktion)

            // get name of elephant                         // Name des Elefants abfragen (nicht elefantspezifische Eigenschaft/Attribut)
            Console.WriteLine(myFirstElephant.name);


            /*
            etc.
            etc.
            etc.
             */

            #region Damit die Konsole sich nicht schliesst
            Console.WriteLine(Environment.NewLine + "Press any key to close programme.");
            Console.ReadKey();
            #endregion
        }
    }
}