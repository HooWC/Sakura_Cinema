using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class Actor
	{
		[Key]
		public int ActorID { get; set; }
		public string? ActorName { get; set; }
		public string? ActorImage { get; set; }
	}
}
