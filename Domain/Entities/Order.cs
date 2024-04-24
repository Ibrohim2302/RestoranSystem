using Domain.Abstract;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Order : EntityBase
{
    public DateTime OrderTime { get; set; }

    public string? Location { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public virtual List<OrderItem>? Items { get; set; }
    
    public OrderType Type { get; set; }
    
    public Customer? Customer { get; set; }
    
    public int CustomerId { get; set; }
    
    public Table? Table { get; set; }
    
    public int TableId { get; set; }
    
    public ICollection<Table>? Tables { get; set; }

    public Payment Payment { get; set; }

}
