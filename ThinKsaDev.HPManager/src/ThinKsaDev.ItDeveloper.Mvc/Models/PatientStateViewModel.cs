using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Mvc.Models
{
    public class PatientStateViewModel
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; }
    }
}
