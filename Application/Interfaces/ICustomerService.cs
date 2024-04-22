﻿using Application.Requests.CustomerRequests;
using Responses.CustomerResponses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ICustomerService : IBaseService<Customer>
    {

    }
}