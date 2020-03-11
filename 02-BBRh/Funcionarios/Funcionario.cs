using System;

namespace _02_BBRh.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }


        //public double GetBonificacao()
        //virtual - tem uma implementação mas permite que outra classe sobreescreva o metodo
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
