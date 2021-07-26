using System;
	

	public abstract class Mamifero: Animal
	{
		 public string Pelaje { get; set; }

		 public void Peludo()
		 {
			 Console.WriteLine("Peludo");
		 }
		 
	    public int Patas { get; set; }
	

	    public void Caminar()
	    {
	        Console.WriteLine("Caminando");
	    }
	}
