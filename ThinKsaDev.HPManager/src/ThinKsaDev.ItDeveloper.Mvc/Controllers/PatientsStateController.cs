using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThinKsaDev.ItDeveloper.Data.Data.ORM;
using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Mvc.Controllers
{
    public class PatientsStateController : Controller
    {
        //vai representar o dbContext, o contexto do banco de dados
        private readonly ApplicationDbContext _context;
        //injeção de dependencia através do construtor
        public PatientsStateController(ApplicationDbContext context)
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
        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }

        //O Bind garante uma segurança, pois em um ataque o atacante precisa saber os campos que tem que passar.
        [HttpPost()]
        [ValidateAntiForgeryToken] //Validação anti ataque CSRS, usar em metodos de ação enquanto não tem validação global para isso.
        public async Task<IActionResult> Create([Bind("Descricao")] PatientState patientState) /*(PatientState patientState)*/
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

        //[HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var patientState = await _context.PatientState.FindAsync(id);

            return patientState switch
            {
                null => NotFound(),
                _ => View(patientState)
            };
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Descricao, Id")] PatientState patientState)
        {
            if (id != patientState.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientState);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (PatientStateExists(patientState.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patientState);
        }


        //teste de concorrencia para validar se não tem mais ninguem fazendo edição no mesmo local ao mesmo tempo.
        private bool PatientStateExists(Guid id)
        {

            //pergunto ao contexto se dentro dele a algum objeto com esse id?
            //vai retornar um bool
            return _context.PatientState.Any(x => x.Id == id);

        }
    }
}
