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
            var patients = GetPatients();

            return View(patients);
        }

        [Route("patient-detail/{id}")]
        public IActionResult PatientDetails(string id)
        {
            return View();
        }

        [Route("add-patient")]
        [HttpPost("add-patient")]
        public IActionResult AddPatient()
        {
            return View();
        }

        #region: Lista de Pacientes
        private List<Patient> GetPatients()
        {
            var patients = new List<Patient>()
            {
                new Patient()
                {
                    Name = "Thiago",
                    Cpf = "12345678910",
                    Telefones = new List<Telefone>()
                    {
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Residencial", Numero = "123456700"},
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Profissional", Numero = "123456701"},
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Movel", Numero = "123456702"}
                    }
                },
                new Patient()
                {
                    Name = "Heloise",
                    Cpf = "12345678910",
                    Telefones = new List<Telefone>()
                    {
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Residencial", Numero = "123456710"},
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Profissional", Numero = "123456711"},
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Movel", Numero = "123456711"}
                    }
                },
                new Patient()
                {
                    Name = "Domenique",
                    Cpf = "12345678910",
                    Telefones = new List<Telefone>()
                    {
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Residencial", Numero = "123456720"},
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Profissional", Numero = "123456721"},
                        new Telefone() {Id = Guid.NewGuid(), PhoneType = "Movel", Numero = "123456722"}
                    }
                }
            };

            return patients;
        }
        #endregion
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
