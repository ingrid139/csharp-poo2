using _02_BBRh.Funcionarios;
using System;

namespace _02_BBRh
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("02!");

            //Funcionario Patricia = new Diretor();

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

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

            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            //após herança na classe de diretor -
            Funcionario robertaFuncionario = roberta;

            Console.WriteLine("Roberta referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Roberta referencia de Funcionario: " + robertaFuncionario.GetBonificacao());
            //após herança na classe de diretor - para funcionar aplicar virtual/override

            Console.ReadKey();

        }
    }
}
