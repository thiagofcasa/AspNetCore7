using System.ComponentModel;
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

        [DisplayName("Nome do Paciente")]
        [StringLength(maximumLength: 80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2 )]
        public string? Name { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "Data inválida.")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Data de Internação")]
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "Data inválida.")]
        public DateTime HospitalizationDate { get; set; }

        //[DisplayName("Data de Inclusão")]
        //public DateTime? IncludeDate { get; set; }

        //[DisplayName("Data da ultima modificação")]
        //public DateTime? LastModifiedDate { get; set; }

        //[DisplayName("Inclusão do usuario")]
        //public string? IncludeUser { get; set; }

        //[DisplayName("Ultima modificação do usuário")]
        //public string? LastUserModified { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Inválido")]
        public string? Email { get; set; }

        public bool Active { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [StringLength(11, ErrorMessage = "Campo {0} deve ter [{1} caracteres", MinimumLength = 11)]
        public string? Cpf { get; set; }

        [DisplayName("Tipo de Paciente")]
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public PatientType PatientType { get; set; }

        [DisplayName("Sexo")]
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public Gender Gender { get; set; }

        [DisplayName("RG")]
        [MaxLength(15, ErrorMessage = "O campo {0} não pode ter mais que (1) caracteres.")]
        public string? Rg { get; set; }

        [DisplayName("Orgão de emissão")]
        [MaxLength(10, ErrorMessage = "O campo {0} não pode ter mais que (1) caracteres.")]
        public string? PlaceOfIssue { get; set; }

        [Display(Name = "Data de Emissão")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
        public DateTime IssueDate { get; set; }

        [MaxLength(90, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        public string? Reason { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " - " + Name;
        }
    }
}
