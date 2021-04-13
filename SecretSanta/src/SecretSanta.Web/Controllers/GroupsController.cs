using Microsoft.AspNetCore.Mvc;
namespace SecretSanta.Web.Controllers{
    public class GroupsController : Controller
    {
        public ActionResult Index(){
            return View();
        }
    }
}