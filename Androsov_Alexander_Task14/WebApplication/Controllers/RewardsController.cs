using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task14;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class RewardsController : Controller
    {
        public RewardsController()
        {
        }

        // GET: Rewards
        public ActionResult Index()
        {
            var rewardsViewModel = new RewardsViewModel
            {
                Models = Storage.GetAwardList().ToList<Award>()
            };
            return View(rewardsViewModel);
        }

        public ActionResult CreateReward()
        {
            Award award = new Award();

            ViewBag.Title = "Create";
            ViewBag.SubmitButtonText = "Create";
            ViewBag.SubmitAction = "CreateReward";
            ViewBag.SubmitController = "Rewards";
            return View("EditReward", award);
        }

        [HttpPost]
        public ActionResult CreateReward(Award reward)
        {
            if (reward != null)
            {
                Storage.AddAwardToList(reward);
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditReward(string title)
        {
            Award reward = new Award();
            if (id != null)
            {
                reward = Storage.GetAwardByTitle(title);
            }

            ViewBag.Title = "Edit";
            ViewBag.SubmitButtonText = "Update";
            ViewBag.SubmitAction = "EditReward";
            ViewBag.SubmitController = "Rewards";
            return View(reward);
        }

        [HttpPost]
        public ActionResult EditReward(Award reward, string title, string description)
        {
            if (reward != null)
            {
                Storage.EditAward(reward, title, description);
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveReward(string title)
        {
            Award award = new Award();
            award = Storage.GetAwardByTitle(title);

            return View(award);
        }

        [HttpPost]
        public ActionResult RemoveReward(string title,int id)
        {
            if (id != null)
            {
                Storage.RemoveAwardFromList(Storage.GetAwardByTitle(title));
            }
            return RedirectToAction("Index");
        }
    }
}