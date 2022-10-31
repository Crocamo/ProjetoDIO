using ExemploPOO.Models;
using ExemploPOO.Interfaces;
namespace ExemploPOO
{
    class Program 
    {
        static void Main(string[] args)
        {
           ICalculadora Calc = new Calculadora();
           System.Console.WriteLine(Calc.Dividir(10 , 3));       
           
            // Corrente conta = new Corrente();
            // conta.Creditar(100);
            // conta.ExibirSaldo();



            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("resultado da Primeira soma " + calc.Somar(5,5));

            // System.Console.WriteLine("resultado da Segunda soma " + calc.Somar(5,5,5));



            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento ="1223456";
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Bob";
            // p2.Idade = 20;
            // p2.Documento ="1223456";
            // p2.Salario = 2000;
            // p2.Apresentar();

            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(10,10);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");
            
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,10);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");


            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}