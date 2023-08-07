using Microsoft.AspNetCore.Mvc;

namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.PatientState
{
    [ViewComponent(Name = "PatientState")]
    public class PatientStateViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
