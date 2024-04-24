using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Customer : EntityBase
{
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public ICollection<Order>? Orders { get; set; }
    public ICollection<Reservation>? Reservations { get; set; }

}
