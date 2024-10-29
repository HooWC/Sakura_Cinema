﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DomainModelEntity.Models;

namespace Insfrastructure.Repository
{
	public class ReservationRepository : RepositoryBase<Reservation>, IReservation
	{
		public ReservationRepository(AppDbContext appDbContext) : base(appDbContext)
		{

		}
	}
}
