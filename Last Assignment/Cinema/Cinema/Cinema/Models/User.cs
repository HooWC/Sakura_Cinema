using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
	public class User
	{
		public int UserID { get; set; }
		public string Avatar { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool OneSignalOpen { get; set; }
	}
}
