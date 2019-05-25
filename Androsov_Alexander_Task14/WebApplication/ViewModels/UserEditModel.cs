using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersAndRewards.Entities;

namespace WebApplication.ViewModels
{
	public class UserEditModel
	{
		public User User { get; set; }

		public Dictionary<Reward, bool> RewardsModel { get; set; }

		public UserEditModel()
		{
			User = new User();
			RewardsModel = new Dictionary<Reward, bool>();
		}
	}
}