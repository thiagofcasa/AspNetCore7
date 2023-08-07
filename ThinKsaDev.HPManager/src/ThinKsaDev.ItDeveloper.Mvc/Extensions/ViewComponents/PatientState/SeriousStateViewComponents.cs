using Microsoft.AspNetCore.Mvc;

namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.PatientState
{
    [ViewComponent(Name = "SeriousState")]
    public class SeriousStateViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
