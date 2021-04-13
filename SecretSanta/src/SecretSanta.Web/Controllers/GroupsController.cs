using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SecretSanta.Web.ViewModels;

namespace SecretSanta.Web.Controllers{
    public class GroupsController : Controller
    {
        static List<GroupViewModel> groups = new List<GroupViewModel>();
        public IActionResult Index(){
            return View(groups);
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(GroupViewModel group){
            if(ModelState.IsValid){
                groups.Add(group);
                return RedirectToAction(nameof(Index));
            }

            return View(group);
        }
        public IActionResult Edit(int id){
            groups[id].Id = id;
            return View(groups[id]);
        }

        [HttpPost]
        public IActionResult Edit(GroupViewModel group){
            if(ModelState.IsValid){
                groups[group.Id] = group;
                return RedirectToAction(nameof(Index));
            }

            return View(group);
        }

        [HttpPost]
        public IActionResult Delete(int id){
            groups.RemoveAt(id);
            return RedirectToAction(nameof(Index));
        }
    }
}