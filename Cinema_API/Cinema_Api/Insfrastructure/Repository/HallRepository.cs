using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DomainModelEntity.Models;

namespace Insfrastructure.Repository
{
	public class HallRepository : RepositoryBase<Hall>, IHall
	{
		public HallRepository(AppDbContext appDbContext) : base(appDbContext)
		{

		}
	}
}
