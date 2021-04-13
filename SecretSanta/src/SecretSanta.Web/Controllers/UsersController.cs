using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SecretSanta.Web.ViewModels;

namespace SecretSanta.Web.Controllers{
    public class UsersController : Controller
    {
        static List<UserViewModel> users = new List<UserViewModel>();
        public IActionResult Index(){
            return View(users);
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserViewModel user){
            if(ModelState.IsValid){
                users.Add(user);
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }
        public IActionResult Edit(int id){
            users[id].Id = id;
            return View(users[id]);
        }

        [HttpPost]
        public IActionResult Edit(UserViewModel user){
            if(ModelState.IsValid){
                users[user.Id] = user;
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        [HttpPost]
        public IActionResult Delete(int id){
            users.RemoveAt(id);
            return RedirectToAction(nameof(Index));
        }
    }
}