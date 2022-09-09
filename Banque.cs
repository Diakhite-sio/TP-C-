using System;
using System.Collections.Generic;

public class Banque
{
	Compte compte;
	public List<Compte> compteList = new List<Compte> ();


	public Banque()
	{
	}
	

	public void Ajouter(Compte c )
    {
		compteList.Add(c);
    }
		
	public void Afficher()
    {
		foreach(Compte c in compteList)
        {
			Console.WriteLine(c.NumeroCompte);
        }
    }

	public void Superieur(Compte c1, Compte c2)
    {
		if (c1.Solde > c2.Solde)
        {
			Console.WriteLine("le Compte 1 :" + c1.NumeroCompte + " est superieur au compte 2 : " + c2.NumeroCompte);
        }

		if (c1.Solde < c2.Solde)
        {
			Console.WriteLine("le Compte 2 no :" + c2.NumeroCompte + " est superieur au compte 1 no :" + c1.NumeroCompte);
		}
    }


}
