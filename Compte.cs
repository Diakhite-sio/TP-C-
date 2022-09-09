using System;

public class Compte
{
	private string nomCompte;
	private int numeroCompte;
	private double solde;
	private double decouvertAutoriser;


	public Compte()
	{
	}

	public Compte( int numero, string nom, double leSolde, double leDecouvertAutoriser)
	{
		this.nomCompte = nom;
		this.numeroCompte = numero;
		this.solde = leSolde;
		this.decouvertAutoriser = leDecouvertAutoriser;
	}

	public string NomCompte
	{
		get { return nomCompte; }
		set { nomCompte = value; }
	}

	public int NumeroCompte
	{
		get { return numeroCompte; }
		set { numeroCompte = value; }
	}

	public double Solde
	{
		get { return solde; }
		set { solde = value; }
	}

	public double DecouvertAutoriser
	{
		get { return decouvertAutoriser; }
		set { decouvertAutoriser = value; }
	}

	//methode 

	public double Crediter(double Somme)
	{
		Solde = Solde + Somme;
		return Solde;
	}

	public double Debiter(double difference)
    {
		if (difference > solde)
		{
			Solde = difference - solde;
			if (solde < 0)
			{
				decouvertAutoriser = decouvertAutoriser - Solde;
				return decouvertAutoriser;
			}
		}
		else
		{
			Solde = Solde - difference;

		}

		return Solde;
	}

	public Compte Transferer (Compte c2, double compteTransferer)
	{
		Debiter(compteTransferer);
		c2.Crediter(compteTransferer);
		return c2;

	}
	 public void Afficher()
    {
		Console.WriteLine("Le Numero du compte est : " + NumeroCompte);
		Console.WriteLine("Le Nom du compte est : " + NomCompte);
		Console.WriteLine("Le solde est : " + Solde);
		Console.WriteLine("Le decouvert autoriser" + DecouvertAutoriser);

			
    }

}

		
	
