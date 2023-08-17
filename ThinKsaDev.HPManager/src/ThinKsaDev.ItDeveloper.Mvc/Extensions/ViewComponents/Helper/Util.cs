using Microsoft.EntityFrameworkCore;
using ThinKsaDev.ItDeveloper.Data.Data.ORM;

namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.Helper
{
    public static class Util
    {
        public static int TotReg(ApplicationDbContext ctx)
        {
            return (from patient in ctx.Patient.AsNoTracking() select patient).Count();
        }

        public static decimal GetNumberRegStatus (ApplicationDbContext ctx, string status)
        {
            return ctx.Patient.AsNoTracking()
                .Count(x => x.PatientState.Description.Contains(status));
        }
    }
}
