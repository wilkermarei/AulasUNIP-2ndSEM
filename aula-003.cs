using System;
					
public class Program
{
	public static void Main()
	{
		int numero = 0; 
		
		Console.WriteLine("Digite um numero:");
		numero = Convert.ToInt32(Console.ReadLine());
		
		switch (numero)
		{
			case 1:
			Console.WriteLine("voce digitou o numero 1");
			break;
			
			default:
			Console.WriteLine("Voce digitou outro valor diferente de 1");
			break;
		}
		
	}
}