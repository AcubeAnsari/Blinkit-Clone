using Microsoft.AspNetCore.Mvc;

namespace Temp.Areas.Dashboard.ViewComponents
{


    [ViewComponent(Name = "SideBar")]
    public class SideBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Index");
        }
    }
}
