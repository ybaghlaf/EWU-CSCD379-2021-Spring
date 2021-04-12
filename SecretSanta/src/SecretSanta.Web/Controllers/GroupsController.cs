using Microsoft.AspNetCore.Mvc;
namespace SecretSanta.Web.Controllers{
    public class GroupsController : Controller
    {
        public ActionResult Groups(){
            return View();
        }
    }
}