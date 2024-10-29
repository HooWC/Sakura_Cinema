using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelEntity.Models;

namespace Contracts
{
	public interface IRepositoryWrapper
	{
		IAdmin Admin { get; }
		IHall Hall { get; }
		IMovie Movie { get; }
		IPayment Payment { get; }
		IReservation Reservation { get; }
		ISeatReservation SeatReservation { get; }
		IShow Show { get; }
		IUser User { get; }
		IActor Actor { get; }
		IDirector Director { get; }
		void Save();
	}
}
