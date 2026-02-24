namespace Projektuppgift.Models;

public class FacilityModel
{
    public int FacilityId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Description { get; set; }

    public List<BookingModel> Bookings { get; set; } = new();
}
