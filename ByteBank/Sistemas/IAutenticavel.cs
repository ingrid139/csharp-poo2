using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    //public abstract class Autenticavel : Funcionario
    //{
    //    public Autenticavel(double salario, string cpf) : base(salario, cpf)
    //    {
    //    }
    //    public string Senha { get; set; }
    //    public bool Autenticar(string senha)
    //    {
    //        return Senha == senha;
    //    }
    //}
    //é um contrato onde quem assina se responsabiliza por implementar esses métodos (cumprir o contrato)
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
