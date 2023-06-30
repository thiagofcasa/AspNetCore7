using System.ComponentModel.DataAnnotations;
using ThinKsaDev.ItDeveloper.Domain.Entities;
using ThinKsaDev.ItDeveloper.Domain.Enums;

namespace ThinKsaDev.ItDeveloper.Mvc.Models
{
    public class PatientViewModel
    {
        [Key]
        [Display(Name = "Id do Paciente")]
        public Guid Id { get; set; }

        public Guid PatientStateId { get; set; }
        public virtual PatientState? PatientState { get; set; }

        public string? Name { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} está inválido")]
        public DateTime BirthDate { get; set; }

        [Display(Name="Data de Internação")]
        public DateTime HospitalizationDate { get; set; }
        public string? Email { get; set; }
        public bool Active { get; set; }
        public string? Cpf { get; set; }
        public PatientType PatientType { get; set; }
        public Gender Gender { get; set; }
        public string? Rg { get; set; }

        [Display(Name = "Data de Emissão")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} está inválido")]
        public DateTime IssueDate { get; set; }
        public string? Reason { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " - " + Name;
        }
    }
}
