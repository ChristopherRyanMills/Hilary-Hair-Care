using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HilaryHairCare.Models;

public class Appointment
{
    public int Id {get; set; }
    public int CustomerId {get; set; }
    public Customer? Customer {get; set; }
    public int StylistId {get; set; }
    public Stylist? Stylist {get; set; }
    public List<Service>? Services {get; set; }
    public DateTime StartTime {get; set; }
    public double? TotalCost
    {
        get
        {
            if (Services.Count > 0 && Services != null)
            {
                return Services.Sum(s => s.Price);
            }
            else {return null;}
        }
    }
}