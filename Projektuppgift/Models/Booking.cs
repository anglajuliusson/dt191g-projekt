namespace Projektuppgift.Models;

public class BookingModel
{
    public int BookingId { get; set; }

    public int FacilityId { get; set; }
    public FacilityModel Facility { get; set; } = null!;

    public int AssociationId { get; set; }
    public AssociationModel Association { get; set; } = null!;

    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public string? Status { get; set; }
}
