using System;

namespace _04_ByteBankRh.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base (5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }
        public override double GetBonificacao()
        {
            //return Salario + base.GetBonificacao();
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
