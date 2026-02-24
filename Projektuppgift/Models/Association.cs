namespace Projektuppgift.Models;

public class Association
{
    public int AssociationId { get; set; }
    public string? Name { get; set; }
    public string? ContactEmail { get; set; }

    public List<Booking> Bookings { get; set; } = new();
}
