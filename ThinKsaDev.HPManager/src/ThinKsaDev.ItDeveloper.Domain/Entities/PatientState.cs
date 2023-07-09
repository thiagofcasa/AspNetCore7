using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ThinKsaDev.ItDeveloper.Domain.Entities.Base;

namespace ThinKsaDev.ItDeveloper.Domain.Entities
{
    public class PatientState : EntityBase
    {
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(maximumLength:20, ErrorMessage = "O campo {0} deve conter entre {2} e {1}", MinimumLength = 2)]
        public string? Description { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; }
    }
}
