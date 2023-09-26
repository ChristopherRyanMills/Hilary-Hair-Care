using System.ComponentModel.DataAnnotations;

namespace HilaryHairCare.Models;

public class Service
{
    public int Id {get; set; }
    [Required]
    public string Name {get; set; }
    public double Price {get; set; }
}