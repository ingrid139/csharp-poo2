using _05_ByteBankRh.Funcionarios;

namespace _05_ByteBankRh.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }

}
