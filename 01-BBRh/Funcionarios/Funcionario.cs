using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BBRh.Funcionarios
{
    public class Funcionario
    {
        //public Funcionario(int tipo)
        //0 - funcionario sem deficição de cargo
        //1- diretor
        //2 - designer
        //N - ...
        //private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //public double Bonificacao
        //{
        //    get
        //    {
        //        return Salario * 0.10;
        //    }
        //}
        //quando quer deixar claro que há um processamento (o calculo) não utilizamos sintax acima
        //public double GetBonificacao()
        //virtual permite que outra classe sobreescreva o metodo
        public virtual double GetBonificacao()
        {
            //if (_tipo == 1)
            //    return Salario;
            //adicionar classe diretor

            return Salario * 0.10;
        }
        
    }
}
