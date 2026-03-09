using System.ComponentModel.DataAnnotations;

namespace Projektuppgift.Models;

public class Booking
{
    public int BookingId { get; set; }

    [Required(ErrorMessage = "Välj en lokal.")]
    public int FacilityId { get; set; }
    public Facility? Facility { get; set; }

    [Required(ErrorMessage = "Välj en förening.")]
    public int AssociationId { get; set; }
    public Association? Association { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
    public DateTime StartDateTime { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
    public DateTime EndDateTime { get; set; }

    public string? Status { get; set; }
}
