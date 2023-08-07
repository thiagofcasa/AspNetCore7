using Microsoft.AspNetCore.Mvc;

namespace ThinKsaDev.ItDeveloper.Mvc.Extensions.ViewComponents.PatientState
{
    [ViewComponent(Name = "ObservationState")]
    public class ObservationStateViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
