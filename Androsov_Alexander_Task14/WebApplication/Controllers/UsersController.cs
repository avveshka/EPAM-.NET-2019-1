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
	public class UsersController : Controller
	{

		public UsersController()
		{
		}

		// GET: Users
		public ActionResult Index()
		{
            var users = Storage.GetUserList().ToList();

			var userViewModels = users.Select(UserViewModel.GetModel).ToList();

			return View(userViewModels);
		}

		public ActionResult CreateUser()
		{
			UserEditModel userEditModel = new UserEditModel();

            var allRewards = Storage.GetAwardList().ToList();

			foreach (var item in allRewards)
			{
				userEditModel.RewardsModel.Add(item, userEditModel.User.Rewards.Any(i => i.ID == item.ID));
			}

			ViewBag.Title = "Create";
			ViewBag.SubmitButtonText = "Create";
			ViewBag.SubmitAction = "CreateUser";
			ViewBag.SubmitController = "Users";
			return View("EditUser", userEditModel);
		}

		[HttpPost]
		public ActionResult CreateUser(UserEditModel userEM)
		{
			if (userEM != null)
			{
				List<Award> rewards = userEM.RewardsModel.Where(x => x.Value == true).Select(x => Storage.GetAwardByTitle(x.Key.title)).ToList();
				userEM.User.Rewards = rewards;
				Storage.AddUserToList(userEM.User);
			}

			return RedirectToAction("Index");
		}

		public ActionResult EditUser(int? id)
		{
			UserEditModel userEditModel = new UserEditModel();

			if (id != null)
			{
				userEditModel.User = bll.GetUserById((int)id);
				//userEditModel.Rewards = bll.GetRewards().ToList();
			}

			ViewBag.Title = "Edit";
			ViewBag.SubmitButtonText = "Update";
			ViewBag.SubmitAction = "EditUser";
			ViewBag.SubmitController = "Users";
			return View(userEditModel);
		}

		[HttpPost]
		public ActionResult EditUser(User user)
		{
			if (user != null)
			{
				Storage.EditUser(user);
			}
			return RedirectToAction("Index");
		}

		public ActionResult RemoveUser(int id)
		{
			User user = new User();

			user = Storage.GetUserById(id);

			return View(user);
		}

		[HttpPost]
		public ActionResult RemoveUser(int? id)
		{
			if (id != null)
			{
				Storage.RemoveUser(Storage.GetUserById((int)id));
			}
			return RedirectToAction("Index");
		}
	}
}