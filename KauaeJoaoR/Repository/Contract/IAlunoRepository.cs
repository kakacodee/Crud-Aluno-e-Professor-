using KauaeJoaoR.Models;

namespace KauaeJoaoR.Repository.Contract
{
    public interface IAlunoRepository
    {
        //Aluno Cadastro(string Nome, string Email);

         void Cadastrar(Aluno aluno);
        public IEnumerable<Aluno> ObterAluno();
    }
}
