using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }

        public PartialViewResult Headpartial()
        {
            return PartialView();
        }

        public PartialViewResult Preloadpartial()
        {
            return PartialView();
        }

        public PartialViewResult NavHeaderdpartial()
        {
            return PartialView();
        }

        public PartialViewResult Headerdpartial()
        {
            return PartialView();
        }

        public PartialViewResult SideBardpartial()
        {
            return PartialView();
        }

        public PartialViewResult ContentBardpartial()
        {
            return PartialView();
        }
        
      
    }
}
