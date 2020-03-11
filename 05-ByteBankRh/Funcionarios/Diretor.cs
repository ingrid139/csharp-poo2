using _05_ByteBankRh.Sistemas;
using System;

namespace _05_ByteBankRh.Funcionarios
{
    //public class Diretor : Funcionario
    public class Diretor : Autenticavel
    {
        //public string Senha { get; set; }
        public Diretor(string cpf) : base (5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //public bool Autenticar(string senha)
        //{
        //    return Senha == senha;
        //}
    }
}
