using System;

class Program
{
    static void Main(string[] args)
    {

        int numero, aux, digito, soma = 0;
        int digitoM = 1;

        Console.WriteLine("Insira um numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        aux = numero;

        while (aux > 0)
        {
            digito = aux % 10;
            digitoM *= aux % 10;
            aux /= 10;
            soma += digito;

        }

        Console.WriteLine($" {digitoM - soma}  ");
    }
}