using ThinKsaDev.ItDeveloper.Domain.Entities.Base;
using ThinKsaDev.ItDeveloper.Domain.Enums;

namespace ThinKsaDev.ItDeveloper.Domain.Entities
{
    public class Patient : EntityBase
    {
        public Patient()
        {
            Active = true;
        }

        public Guid PatientStateId { get; set; }
        public virtual PatientState? PatientState { get; set; }

        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HospitalizationDate { get; set; }
        public string? Email { get; set; }
        public bool Active { get; set; }
        public string? Cpf { get; set; }
        public PatientType PatientType { get; set; }
        public Gender Gender { get; set; }
        public string? Rg { get; set; }
        public DateTime IssueDate { get; set; }
        public string? Reason { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " - " + Name;
        }
    }
}
