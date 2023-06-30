using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Mvc.Models
{
    public class PatientStateViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = ("O Campo {0} é obrigatório."))]
        [StringLength(20, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string? Description { get; set; }

        public virtual ICollection<Patient>? Patients { get; set; }
    }
}
