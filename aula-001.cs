//1o. Arquivo Commitado no github

using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		string nome = "Wilker";
		string frase1 = "Hello";
		string frase2 = "WOrld";
		string recebe;
		string recebe2;
		int tam;
		
		Console.WriteLine("{0} {1} {2} tamanho da frase: {3} caracteres... ",frase1,frase2,nome,(nome+frase1+frase2).Length);
		recebe = Console.ReadLine();
		recebe2 = recebe;
		Console.WriteLine(recebe2.Length);
		
		
		Console.WriteLine("Entre com tamanho de caracteres a tomar");
		tam = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(recebe.Substring(0,tam));
		
	}
}