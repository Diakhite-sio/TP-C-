using System;

namespace TP1_Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 instantiation  de compte 
            Compte c, c1;
            c = new Compte(1, "toto", 1000, -500);
            c1 = new Compte(2, "tata", 1000, -500);

            //les methodes de la classe compte 
            c.Transferer(c1, 1000); // transferer le l'argent du compte 1 au compte 2 et ajouté l'argent dans le parametre 
            c.Afficher();
            Console.WriteLine(' ');
            c1.Afficher();
            c.Transferer(c1, 1000);

            //instantiation de la classe banque 
            Console.WriteLine(' ');
            Console.WriteLine(' ');
            Banque b = new Banque();

            //methode de la classe banque 
            b.Ajouter(c);
            b.Ajouter(c1);
            b.Afficher();
            Console.WriteLine(' ');
            b.Superieur(c1, c);//

        }
    }
}
