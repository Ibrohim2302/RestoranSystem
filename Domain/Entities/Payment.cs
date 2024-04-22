using RMS.Domain.Abstract;
using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities;

public class Payment : EntityBase
{
    public DateTime PaymentDate { get; set; }
    public decimal PaymentAmount { get; set; }
    public  PaymentType Type { get; set; }
    public PaymentStatus Status { get; set; }
    public Order? Order { get; set; }
    public int OrderId { get; set; }
}
