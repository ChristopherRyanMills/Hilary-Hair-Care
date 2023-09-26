using System.ComponentModel.DataAnnotations;

namespace HilaryHairCare.Models;

public class AppointmentServices
{
    public int Id {get; set; }
    public int ServiceId {get; set; }
    public int AppointmentId {get; set; }
}