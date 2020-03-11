using _03_ByteBankRh.Funcionarios;
using System;

namespace _03_ByteBankRh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03!");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carolina = new Funcionario(2000, "123.543.090-09");
            carolina.Nome = "carolina";
            //carolina.CPF = "123.543.090-09";
            //carolina.Salario = 2000;
            Console.WriteLine(carolina.Nome);
            Console.WriteLine("Carolina bonificacao: " + carolina.GetBonificacao());
            
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carolina);

            Diretor roberta = new Diretor("098.869.040-068");
            roberta.Nome = "Roberta";
            //roberta.CPF = "098.869.040-068";
            //roberta.Salario = 5000;
            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Roberta bonificacao: " + roberta.GetBonificacao());

            gerenciador.Registrar(roberta);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            carolina.AumentarSalario();
            Console.WriteLine("Novo salário Carolina: " + carolina.Salario);

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário Roberta: " + roberta.Salario);
            //roberta.Salario = 2200;


            Console.ReadKey();
        }
    }
}
