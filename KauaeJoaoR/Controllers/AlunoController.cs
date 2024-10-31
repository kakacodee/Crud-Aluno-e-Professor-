using KauaeJoaoR.Models;
using KauaeJoaoR.Repository;
using KauaeJoaoR.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace KauaeJoaoR.Controllers
{
    public class AlunoController : Controller
    {
        private IAlunoRepository _alunoRepository;

        public AlunoController (IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public IActionResult Index()
        {
            return View(_alunoRepository.ObterAluno());
        }
        [HttpGet]
        public IActionResult CadastrarA()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarA(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _alunoRepository.Cadastrar(aluno);
            }
            return View();
        }
    }
}
