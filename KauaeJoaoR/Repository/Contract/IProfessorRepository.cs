using KauaeJoaoR.Models;

namespace KauaeJoaoR.Repository.Contract
{
    public interface IProfessorRepository
    {
        //Professor Cadastro(string Nome, int CPF);

        void Cadastrar(Professor professor);
        public IEnumerable<Professor> ObterProfessor();
    }
}
