﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class User
	{
		[Key]
		public int UserID { get; set; }
		public string? Avatar { get; set; }
		public string? FullName { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string? Username { get; set; }
		public string? Password { get; set; }
		public bool OneSignalOpen { get; set; }
	}
}
