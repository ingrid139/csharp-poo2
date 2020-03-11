using _04_ByteBankRh.Funcionarios;
using System;

namespace _04_ByteBankRh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("04!");
            
            CalcularBonificação();
            
            Console.ReadKey();
        }
        
        //não é possível chamar um método de instancia (que não é static) dentro de um método static
        //método Main sempre static pois não pertence a um objeto e sim a classe
        //public void CalcularBonificação()
        public static void CalcularBonificação()
        {
            //classe abstrata não pode ser instanciada
            //Funcionario teste = new Funcionario(200, "3457.797");
            //teste.GetBonificacao();

            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            //tipo concreto
            //Designer patricia = new Designer("833.222.048-39");
            //podemos ter variáveis do tipo abstrato
            Funcionario patricia = new Designer("833.222.048-39");
            patricia.Nome = "Patricia";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar daniela = new Auxiliar("981.198.778-53");
            daniela.Nome = "Daniela";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(patricia);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(daniela);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                                gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
