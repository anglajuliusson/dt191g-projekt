namespace Projektuppgift.Models;

public class Facility
{
    public int FacilityId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Description { get; set; }

    public List<Booking> Bookings { get; set; } = new();
}
