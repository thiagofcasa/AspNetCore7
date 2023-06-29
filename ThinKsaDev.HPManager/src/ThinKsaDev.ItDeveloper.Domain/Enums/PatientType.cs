using System.ComponentModel;

namespace ThinKsaDev.ItDeveloper.Domain.Enums
{
    public enum PatientType
    {
        [Description("Conveniado")] Conveniado = 1,
        [Description("Particular")] Particular,
        [Description("Outros")] Outros
    }
}
