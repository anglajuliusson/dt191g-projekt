namespace Projektuppgift.Models;

public class Booking
{
    public int BookingId { get; set; }

    public int FacilityId { get; set; }
    public Facility? Facility { get; set; }

    public int AssociationId { get; set; }
    public Association? Association { get; set; }

    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public string? Status { get; set; }
}
