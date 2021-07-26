using System;

public abstract class Aves: Animal
{
    public string Alas { get; set; }

    public void Volar()
    {
        Console.WriteLine("Volando");
    }

    
     public int Patas { get; set; }
	

	    public void Caminar()
	    {
	        Console.WriteLine("Caminando");
	    }
}