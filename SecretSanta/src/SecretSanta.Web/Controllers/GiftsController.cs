using Microsoft.AspNetCore.Mvc;
namespace SecretSanta.Web.Controllers{
    public class GiftsController : Controller
    {
        public ActionResult Index(){
            return View();
        }
    }
}