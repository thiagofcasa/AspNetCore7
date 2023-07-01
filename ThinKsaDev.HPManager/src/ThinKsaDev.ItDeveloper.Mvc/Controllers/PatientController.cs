using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace ThinKsaDev.ItDeveloper.Mvc.Controllers
{
    [Route("")]
    [Route("patient-management")]
    [Route("patients-management")]
    public class PatientController : BaseController
    {
        //[Route("")] ou [HttpGet("")]
        [Route("patients")]
        [Route("get-pacient")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("patient-detail/{id}")]
        public IActionResult PatientDetails(string id)
        {
            return View();
        }


    }

    public class Patient
    {
        public Patient()
        {
            Id = Guid.NewGuid();
            Telefones = new HashSet<Telefone>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }

    public class Telefone
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? PhoneType { get; set; }
        public string? Numero { get; set; }
    }
}
