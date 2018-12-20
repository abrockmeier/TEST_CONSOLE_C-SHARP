using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_CONSOLE_C_SHARP
{
	class Program
	{
		static void Main(string[] args)
		{
		//Variablen
		int a, b, c, ergebnis;
		string eingabe, text = "", flaeche = "", volumen = "";
		bool aValid, bValid, cValid, flaecheVolumen = true, keineFoderV= false;
		
		//Eingabe
		Console.WriteLine("Bitte geben Sie die erste Ganzzahl ein:");
		eingabe = Console.ReadLine();
		aValid = Int32.TryParse(eingabe, out a);
		

		Console.WriteLine("Bitte geben Sie die zweite Ganzzahl ein:");
		eingabe = Console.ReadLine();
		bValid = Int32.TryParse(eingabe, out b);

		Console.WriteLine("Bitte geben Sie die dritte Ganzahl ein:");
		eingabe = Console.ReadLine();
		cValid = Int32.TryParse(eingabe, out c);
		
		Console.WriteLine("");

			//Verarbeitung und (teilweise)Ausgabe
			if (aValid && bValid && cValid)
			{
				
				
				if (a != 0 && b != 0 && c != 0)
				{
					// Volumen
					ergebnis = a * b * c;
					Console.WriteLine("Die eingegebenen Zahlen {0}, {1}, {2} ergeben ein Gesamtvolumen von:" +
					"{3} ", a, b, c, ergebnis);
					flaecheVolumen = false;
				}
				else if (a == 0) 
				{
				// Fläche
					ergebnis = b * c;
					volumen = Convert.ToString(ergebnis);
					Console.WriteLine("Die eingegebenen Zahlen {0}, {1}, ergeben eine Gesamtfläche von:" +
					"{2} ", b, c, ergebnis);
					flaecheVolumen = true;
				}
				else if (b == 0) 
				{
				// Fläche
					ergebnis = a * c;
					flaeche = Convert.ToString(ergebnis);
					Console.WriteLine("Die eingegebenen Zahlen {0}, {1}, ergeben eine Gesamtfläche von:" +
					"{2} ", a,  c, ergebnis);
					flaecheVolumen = true;
				}
				else if (c == 0) 
				{
				// Fläche
					ergebnis = a * b;
					Console.WriteLine("Die eingegebenen Zahlen {0}, {1}, ergeben eine Gesamtfläche von:" +
					"{2} ", a, b, ergebnis);
					flaecheVolumen = true;
				}
				else
				{
					ergebnis = a + b + c;
					Console.WriteLine("mindestens zwei Zahlen sind 0");
					Console.WriteLine("Sie haben {0}, {1}, und {2} eingegeben!" +
					"Das Ergebnis lautet: {3}",a, b, c, ergebnis);
					keineFoderV = true;
				}

			}
			else
			{
				Console.WriteLine("Sie haben keine Ganzzahlen eingegeben! Bitte Programm erneut aufrufen...");
			}

			for (int i = 0; i < 15; i++)
			{
				text = text + "*" ;
			}
			
		//Ausgabe
		Console.WriteLine(text);
		Console.WriteLine("* Autor: Alexander Brockmeier");
		Console.WriteLine(text);
			if (flaecheVolumen == true )
			{
				Console.WriteLine("Die Fläche beträgt: {0}", flaeche);
			}
			else if (flaecheVolumen == false)
			{ 
				Console.WriteLine("Das Volumen beträgt: {0}", volumen);
			}
			else if (keineFoderV == true)
			{
				Console.WriteLine("Es gibt weder Fläche noch Volumen!");
			}
	
		}
	}
}
