using PI.Models;

namespace PI.Data.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();

        void InserirAluno(Aluno aluno);
        void ExcluirAluno(int id);
        void EditarAluno(Aluno aluno);
        Aluno BuscarId(int id);
    }
}
