using System;
class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua Idade: ");
	    int idade = int.Parse(Console.ReadLine());
	    
            if(idade >= 18)
	       Console.WriteLine("É maior de idade");
            else
              Console.WriteLine("É menor de idade"); 

	    Console.ReadLine();
        }
}

