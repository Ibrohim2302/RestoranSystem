using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Requests.OrderRequests;

public class OrderRequestModel
{
    public DateTime DateTime { get; set; }
    public string? Location { get; set; }
    public decimal TotalPrice { get; set; }
    public int CustomerId { get; set; }
    public int TableId { get; set; }
}
