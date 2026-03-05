using System.ComponentModel.DataAnnotations;

namespace Projektuppgift.Models;

public class Facility
{
    public int FacilityId { get; set; }

    [Required(ErrorMessage = "Namn måste anges.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Adress måste anges.")]
    public string? Address { get; set; }
    public string? Description { get; set; }

    public List<Booking> Bookings { get; set; } = new();
}
