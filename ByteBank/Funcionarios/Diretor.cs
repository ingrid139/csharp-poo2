using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    //nao existe em c# - nao sabemos qual método será executado, mesmo que torne a classe e métodos abstratos
    //public abstract class Casa
    //{
    //    public abstract void AbrirPorta();
    //}
    //Interface nunca terá implementação de método, não há modificador de visibilidade nem abstract
    //Nunca haverá colisão de nomes
    //public interface Casa
    //{
    //    void AbrirPorta();
    //}
    //public abstract class Carro
    //{
    //    public abstract void AbrirPorta();
    //}

    //public class Exemplo : Carro, Casa
    //{
    //    public override void AbrirPorta()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class Diretor : Autenticavel
    //*** Não é permitido implementar herança multipla de classes
    //Nas duas classes temos métodos com o mesmo nome, ao instanciar 
    //public class Diretor : Autenticavel, Funcionario
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base(5000, cpf)
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

    }
}
