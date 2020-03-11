using _01_BBRh.Funcionarios;
using System;

namespace _01_BBRh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01!");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            //Funcionario carolina = new Funcionario();
            //diretor
            Funcionario carolina = new Funcionario();
            carolina.Nome = "carolina";
            carolina.CPF = "123.543.090-09";
            carolina.Salario = 2000;
            Console.WriteLine(carolina.Nome);
            Console.WriteLine("Carolina bonificacao: " + carolina.GetBonificacao());

            gerenciador.Registrar(carolina);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "098.869.040-068";
            roberta.Salario = 5000;
            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Roberta bonificacao: " + roberta.GetBonificacao());

            //Roberta é diretora!
            gerenciador.Registrar(roberta);

            //após sobrecarga de métodos
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            //Total de  bonificacao anual....GerenciadorBonificacao
            //double TotalBonificacoes = carolina.GetBonificacao();
            //double TotalBonificacoes += roberta.GetBonificacao();


        }
    }
}
