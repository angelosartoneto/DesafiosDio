using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        DateTime dataAtual = DateTime.Now;


        public void Apresentar() 
        {
            Console.WriteLine($"Olá mundo! Meu nome é {Nome}, e tenho {Idade} anos. Atualizado em: {dataAtual.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
}