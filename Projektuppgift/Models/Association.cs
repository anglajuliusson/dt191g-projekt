namespace Projektuppgift.Models;

public class AssociationModel
{
    public int AssociationId { get; set; }
    public string? Name { get; set; }
    public string? ContactEmail { get; set; }

    public List<BookingModel> Bookings { get; set; } = new();
}
