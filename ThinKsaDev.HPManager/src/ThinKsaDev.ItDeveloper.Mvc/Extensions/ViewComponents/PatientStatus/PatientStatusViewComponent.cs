using Microsoft.AspNetCore.Mvc;
using ThinKsaDev.ItDeveloper.Data.Data.ORM;
using ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.Helper;

namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.PatientStatus
{
    [ViewComponent(Name = "PatientStatus")]
    public class PatientStatusViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public PatientStatusViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string status)
        {
            var totalGeneral = Util.TotReg(_context);
            decimal totalStatus = Util.GetNumberRegStatus(_context, status);
            decimal progress = (totalGeneral > 0) ? totalStatus * 100 / totalGeneral : 0;
            var prct = progress.ToString("F1");

            CounterPatientStatus model = new()
            {
                Title = $"Pacientes {status}",
                Partial = (int)totalStatus,
                Percent = prct,
                Progress = progress,
                ClassContainer = "panel panel-info tile panelClose panelRefresh",
                IconLg = "l-basic-geolocalize-05",
                IconSm = "fa fa-arrow-circle-o-up s20 mr5 pull-left"
            };

            return await Task.FromResult(View(model));
        }
    }
}
