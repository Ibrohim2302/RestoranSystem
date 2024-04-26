using Application.Interfaces;
using Application.Requests.CustomerRequests;
using Application.Responses.CustomerResponses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICustomerService : IBaseService<Customer>
    {

    }
}
