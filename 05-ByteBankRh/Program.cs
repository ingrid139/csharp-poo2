using _05_ByteBankRh.Funcionarios;
using _05_ByteBankRh.Sistemas;
using System;

namespace _05_ByteBankRh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05!");
            
            UsarSistema();

            Console.ReadKey();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }
        public static void CalcularBonificação()
        {
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
