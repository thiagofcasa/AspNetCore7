using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThinKsaDev.ItDeveloper.Data.Data.ORM;
using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Mvc.Controllers
{
    public class PatientStateController : Controller
    {
        //vai representar o dbContext, o contexto do banco de dados
        private readonly ApplicationDbContext _context;
        //injeção de dependencia através do construtor
        public PatientStateController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Como async retornar uma Task tipada com ActionResult ( uma tarefa )
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //var model = await _context.PatientState.ToListAsync();
            //return View(model);
            return View(await _context.PatientState.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            //if (id == null)
            //    return NotFound("Registro não encontrado!");

            try
            {
                //LINQ - usando o FirstAsync ele retorna alguem e caso não da uma exceção 
                var patientState = await _context.PatientState.FirstOrDefaultAsync(p => p.Id == id);
                return View(patientState);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //O Create retorna o View vazia para preencher e depois sim fazer a inserção.
        [HttpGet("adicionar-estado-paciente")]
        public IActionResult Create()
        {
            return View();
        }

        //O Bind garante uma segurança, pois em um ataque o atacante precisa saber os campos que tem que passar.
        [HttpPost("adicionar-estado-paciente")]
        [ValidateAntiForgeryToken] //Validação anti ataque CSRS, usar em metodos de ação enquanto não tem validação global para isso.
        public async Task<IActionResult> Create([Bind("Descricao, Id")], PatientState patientState)
        {
            //Verifica se o modelo passado é valido.
            if (ModelState.IsValid)
            {
                //Isso ja é feito na EntityBase, esta aqui apenas para conhecimento.
                patientState.Id = Guid.NewGuid();
                _context.Add(patientState);
                await _context.SaveChangesAsync();

                //return RedirectToAction("Index");
                //Boas praticas.
                return RedirectToAction(nameof(Index));
            }

            return View(patientState);
        }

    }
}
