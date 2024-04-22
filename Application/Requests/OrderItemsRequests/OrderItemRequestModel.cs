using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Requests.OrderItemsRequests;

public class OrderItemRequestModel
{
    public int Id { get; set; }
    public int MenuId { get; set; }
    public double Count { get; set; }   
    public OrderStatus Status { get; set; }
}
