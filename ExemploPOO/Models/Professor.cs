using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
         public override void Apresentar()
        {
            Console.WriteLine($"Olá, Sou professor {Nome} meu salario é {Salario}");
        }
    }
}