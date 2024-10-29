using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DomainModelEntity.Models;

namespace Insfrastructure.Repository
{
	public class SeatReservationRepository : RepositoryBase<SeatReservation>, ISeatReservation
	{
		public SeatReservationRepository(AppDbContext appDbContext) : base(appDbContext)
		{

		}
	}
}
