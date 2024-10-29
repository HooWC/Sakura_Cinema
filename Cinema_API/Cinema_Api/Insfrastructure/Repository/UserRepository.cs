using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DomainModelEntity.Models;

namespace Insfrastructure.Repository
{
	public class UserRepository : RepositoryBase<User>, IUser
	{
		public UserRepository(AppDbContext appDbContext) : base(appDbContext)
		{

		}
	}
}
