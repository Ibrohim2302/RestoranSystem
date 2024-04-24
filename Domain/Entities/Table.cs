using Domain.Abstract;
using Domain.Enum;

namespace Domain.Entities;

public class Table : EntityBase
{
    public int Number { get; set; }
    public int Capacity { get; set; }
    public TableStatus Status { get; set; }
    public ICollection<Order>? Orders { get; set; }
}
