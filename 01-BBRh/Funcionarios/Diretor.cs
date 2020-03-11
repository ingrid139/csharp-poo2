using System;

namespace _01_BBRh.Funcionarios
{
    //public class Diretor é um funcionario - aula 2
    public class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario;
        }
    }
}
