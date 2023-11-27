using PI.Data.Repositorio.Interface;
using PI.Models;

namespace PI.Data.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public LoginRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Login ValidarUsuario(Login login)
        {
            return _bancoContexto.Login.FirstOrDefault(a => a.Email == login.Email && a.Senha == login.Senha);
        }

    }
}
