using RMS.Domain.Abstract;
using RMS.Domain.Enum;

namespace RMS.Domain.Entities;

public class Table : EntityBase
{
    public int Number { get; set; }
    public int Capacity { get; set; }
    public TableStatus Status { get; set; }
    public ICollection<Order>? Orders { get; set; }
}
