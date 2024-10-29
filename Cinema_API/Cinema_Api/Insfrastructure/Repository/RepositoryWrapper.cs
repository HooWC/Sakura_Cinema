using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Insfrastructure.Repository
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private AppDbContext DB;

		public RepositoryWrapper(AppDbContext _db)
		{
			DB = _db;
		}

		private IAdmin _admin;
		private IHall _hall;
		private IMovie _movie;
		private IPayment _payment;
		private IReservation _reservation;
		private ISeatReservation _seatReservation;
		private IShow _show;
		private IUser _user;
		private IActor _actor;
		private IDirector _director;

		public IAdmin Admin
		{
			get
			{
				if (_admin == null)
				{
					_admin = new AdminRepository(DB);
				}
				return _admin;
			}
		}

		public IHall Hall
		{
			get
			{
				if (_hall == null)
				{
					_hall = new HallRepository(DB);
				}
				return _hall;
			}
		}

		public IMovie Movie
		{
			get
			{
				if (_movie == null)
				{
					_movie = new MovieRepository(DB);
				}
				return _movie;
			}
		}

		public IPayment Payment
		{
			get
			{
				if (_payment == null)
				{
					_payment = new PaymentRepository(DB);
				}
				return _payment;
			}
		}

		public IReservation Reservation
		{
			get
			{
				if (_reservation == null)
				{
					_reservation = new ReservationRepository(DB);
				}
				return _reservation;
			}
		}

		public ISeatReservation SeatReservation
		{
			get
			{
				if (_seatReservation == null)
				{
					_seatReservation = new SeatReservationRepository(DB);
				}
				return _seatReservation;
			}
		}

		public IShow Show
		{
			get
			{
				if (_show == null)
				{
					_show = new ShowRepository(DB);
				}
				return _show;
			}
		}

		public IUser User
		{
			get
			{
				if (_user == null)
				{
					_user = new UserRepository(DB);
				}
				return _user;
			}
		}

		public IActor Actor
		{
			get
			{
				if (_actor == null)
				{
					_actor = new ActorRepository(DB);
				}
				return _actor;
			}
		}

		public IDirector Director
		{
			get
			{
				if (_director == null)
				{
					_director = new DirectorRepository(DB);
				}
				return _director;
			}
		}


		public void Save()
		{
			DB.SaveChanges();
		}

	}
}
