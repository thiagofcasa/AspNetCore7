using Microsoft.AspNetCore.Mvc;

namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.PatientStatus
{
    [ViewComponent(Name = "CriticalState")]
    public class CriticalStateViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
