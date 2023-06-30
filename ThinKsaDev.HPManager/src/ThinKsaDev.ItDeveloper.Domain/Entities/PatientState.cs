using ThinKsaDev.ItDeveloper.Domain.Entities.Base;

namespace ThinKsaDev.ItDeveloper.Domain.Entities
{
    public class PatientState : EntityBase
    {
        public string? Description { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; }
    }
}
