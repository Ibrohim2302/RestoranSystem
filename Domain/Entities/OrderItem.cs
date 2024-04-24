using Domain.Abstract;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class OrderItem : EntityBase
{
    public MenuItem? MenuItem { get; set; }
    public int MenuItemId { get; set; }

    public double Count { get; set; }

    public OrderStatus Status { get; set; }    
  
}
