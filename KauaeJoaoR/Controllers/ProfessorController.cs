using KauaeJoaoR.Repository;
using KauaeJoaoR.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace KauaeJoaoR.Models
{
    public class ProfessorController : Controller
    {
        private IProfessorRepository _professorRepository;

        public ProfessorController(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }
        public IActionResult Index()
        {
            return View(_professorRepository.ObterProfessor());
        }
        [HttpGet]
        public IActionResult CadastrarP()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarP(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _professorRepository.Cadastrar(professor);
            }
            return View();
        }
    }
}
