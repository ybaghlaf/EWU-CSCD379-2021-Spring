using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SecretSanta.Web.ViewModels;

namespace SecretSanta.Web.Controllers{
    public class GiftsController : Controller
    {
        static List<GiftViewModel> gifts = new List<GiftViewModel>();
        public IActionResult Index(){
            return View(gifts);
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(GiftViewModel gift){
            if(ModelState.IsValid){
                gifts.Add(gift);
                return RedirectToAction(nameof(Index));
            }

            return View(gift);
        }
        public IActionResult Edit(int id){
            gifts[id].Id = id;
            return View(gifts[id]);
        }

        [HttpPost]
        public IActionResult Edit(GiftViewModel gift){
            if(ModelState.IsValid){
                gifts[gift.Id] = gift;
                return RedirectToAction(nameof(Index));
            }

            return View(gift);
        }

        [HttpPost]
        public IActionResult Delete(int id){
            gifts.RemoveAt(id);
            return RedirectToAction(nameof(Index));
        }
    }
}