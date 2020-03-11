using ByteBank.Funcionarios;
using System;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        //public bool Logar(Autenticavel funcionario, string senha)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar(senha);

        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Bem-vindo ao sistema!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta!");
        //        return false;
        //    }
        //}

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
