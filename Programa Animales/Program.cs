using System;
	
	namespace _12_ejercicio_clase_animales
	{
	    class Program
	    {
	        static void Main(string[] args)
	        {
	        

				Console.WriteLine("Mamíferos");
				Console.WriteLine("************");
				Console.WriteLine("");
	
	            Perro p = new Perro();
	            p.Nombre = "Scooby";
				Console.WriteLine("El perro es : " + p.Nombre);
	            p.Patas = 4;
				Console.WriteLine("Tiene: " + p.Patas  + " patas");
				p.Edad();
				Console.WriteLine("Scooby anda: ");
	            p.Comer();
	            p.Caminar();
				Console.WriteLine("Y ladra: ");
	            p.Ladrar();
				

				Console.WriteLine("");


	            Gato g = new Gato();
	            g.Nombre = "Pelusa";
				Console.WriteLine("El gato es: " + g.Nombre);
	            g.Patas = 4;
				Console.WriteLine("Tiene: " + g.Patas  + " patas");
				g.Edad();
	            g.Peludo();
				Console.WriteLine("El gato anda: ");
	            g.Comer();
	            g.Caminar();
				Console.WriteLine("Siempre hace ruidos");
	            g.Maullar();

				Console.WriteLine("");

				Mono m = new Mono();
				m.Nombre = "Claudio";
				Console.WriteLine("El mono se llama : "  +  m.Nombre);
				Console.WriteLine("Claudio es un : " );
				m.Chimpance();
				m.Peludo();
				m.Patas = 2;
				Console.WriteLine("Tiene: " + m.Patas  + " patas");
				Console.WriteLine("El chimpancé anda : ");
				m.Comer();
				m.Caminar();
				m.Trepar();
				m.Ruido();


				Console.WriteLine("");
				Console.WriteLine("Aves");
				Console.WriteLine("****");
				Console.WriteLine("");

                 Aguila a = new Aguila();
	            a.Nombre = "Sara";
				Console.WriteLine("El aguila anda : ");
	            a.Comer();
				a.Caminar();
				a.volar();
				Console.WriteLine("sus colores son: ");
				a.Color();

                 Console.WriteLine("El águila se llama : " +  a.Nombre);
				 
				 Console.WriteLine("");

				 Loro l = new Loro();
				 l.Nombre = "Paco";
				 Console.WriteLine("El loro se llama : " +  l.Nombre);
				 Console.WriteLine("Paco anda : ");
				 l.Hablar();
				 l.Comer();
				 l.Volar();
				 l.Caminar();
				 Console.WriteLine("Y es color: ");
				 l.Color();

				 Console.WriteLine("");

				Console.WriteLine("Peces");
				Console.WriteLine("*****");
				Console.WriteLine("");

				Globo pez = new Globo();
				pez.Nombre = "Tito";
				Console.WriteLine("El pez globo se llama : " + pez.Nombre);
				pez.Aletas = 6;
				Console.WriteLine("Tito tiene : " + pez.Aletas + " aletas ");
				Console.WriteLine("Su color es : ");
				pez.Color();
				Console.WriteLine("Anda: ");
				pez.Comer();
				pez.Nadar();
				


                 
                
	        }
	    }
	}


