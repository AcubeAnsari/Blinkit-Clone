using Microsoft.AspNetCore.Mvc;

namespace Temp.Areas.Dashboard.ViewComponents
{


    [ViewComponent (Name = "Header")]
    public class Header:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Index");
        }
    }
}
