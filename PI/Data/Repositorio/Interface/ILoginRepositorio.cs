using PI.Models;

namespace PI.Data.Repositorio.Interface
{
    public interface ILoginRepositorio
    {

        Login ValidarUsuario(Login login);

    }
}
