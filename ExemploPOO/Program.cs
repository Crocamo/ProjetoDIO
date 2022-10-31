using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program 
    {
        static void Main(string[] args)
        {
            var caminho = "E:\\VS_Projects\\ProjetoDIO\\ExemploPOO\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste3.txt");
            var novoCaminhoArquivo = Path.Combine(caminho,"pasta teste 2", "arquivo-teste-Stream3.txt");
            var copiarArquivo = Path.Combine(caminho, "arquivo-teste2.txt");
            var ArquivoCopiado = Path.Combine(caminho, "pasta teste 2" , "arquivo-teste2-bkp.txt");
            var conteudo = "olá, teste de escrita de arquivo";
            var listaString             = new List<string>{"linha 1","linha 2","linha 3"};
            var listaStringContinuacao  = new List<string>{"linha 4","linha 5","linha 6"};

            FileHelper Helper = new FileHelper();
            
            Helper.DeletarArquivo(ArquivoCopiado);
            // Helper.copiarArquivo(copiarArquivo , ArquivoCopiado, false);
            // Helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo, false);
            // Helper.LerArquivo(caminhoArquivo);
            // Helper.LerArquivoStream(caminhoArquivo);
            // Helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // Helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            // Helper.CriarArquivoTexto(caminhoArquivo, conteudo);
            // Helper.ApagarDiretorio(caminhoPathCombine, true);
            // Helper.CriarDiretorio(caminhoPathCombine);
            // Helper.ListarArquivosDiretorios(caminho);
            // Helper.ListarDiretorios(caminho);        
        
            //  ICalculadora Calc = new Calculadora();
            //  System.Console.WriteLine(Calc.Dividir(10 , 3));       
           
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