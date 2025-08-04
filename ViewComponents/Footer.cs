using Microsoft.AspNetCore.Mvc;
using Temp.Data;

namespace Temp.ViewComponents
{
    [ViewComponent(Name ="Footer")]
    public class Footer : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View("Index");
        }
    }
}
