using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Requests.TableRequests;

public class TableRequestModel
{
    public int Number { get; set; }
    public int Capacity { get; set; }
    public TableStatus Status { get; set; }
}
