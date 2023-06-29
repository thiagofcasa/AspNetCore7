namespace ThinKsaDev.ItDeveloper.Domain.Entities
{
    public class PatientState
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; }
    }
}
