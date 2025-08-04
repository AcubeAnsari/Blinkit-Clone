using Microsoft.AspNetCore.Mvc;
using Temp.Data;

namespace Temp.ViewComponents
{
    [ViewComponent(Name ="Navigation")]
    public class Navigation : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View("Index");
        }
    }
}
