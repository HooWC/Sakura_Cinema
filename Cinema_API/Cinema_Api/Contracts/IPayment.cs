﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelEntity.Models;

namespace Contracts
{
	public interface IPayment : IRepositoryBase<Payment>
	{
	}
}