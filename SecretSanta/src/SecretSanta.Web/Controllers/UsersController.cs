using Microsoft.AspNetCore.Mvc;
namespace SecretSanta.Web.Controllers{
    public class UsersController : Controller
    {
        public ActionResult Users(){
            return View();
        }
    }
}