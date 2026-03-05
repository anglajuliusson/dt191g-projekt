using System.ComponentModel.DataAnnotations;

namespace Projektuppgift.Models;

public class Association
{
    public int AssociationId { get; set; }

    [Required(ErrorMessage = "Föreningsnamn måste anges.")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "E-postadress måste anges.")]
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
    public string? ContactEmail { get; set; }

    public List<Booking> Bookings { get; set; } = new();
}
