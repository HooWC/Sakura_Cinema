using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class Director
	{
		[Key]
		public int DirectorID { get; set; }
		public string? DirectorName { get; set; }
		public string? DirectorImage { get; set; }
	}
}
