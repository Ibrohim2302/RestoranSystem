﻿using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(EFContext context) : base(context)
        {
        }
    }
}
