using Microsoft.AspNetCore.Mvc;

namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.PatientState
{
    [ViewComponent(Name = "SteadyState")]
    public class SteadyStateViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
