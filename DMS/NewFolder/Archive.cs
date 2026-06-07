using Microsoft.AspNetCore.Mvc;

namespace DMS.NewFolder
{
    public class Archive : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
