namespace Backend.Models;

public class Gym
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual City City { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string Owner { get; set; }
    public virtual BuildingOwnership BuildingOwnership { get; set; }
    public string LicenseNumber { get; set; }
    public DateOnly LicenseStart { get; set; }
    public DateOnly LicenseExpiration { get; set; }
    public virtual LicenseOwnership LicenseOwnership { get; set; }
    public virtual Gender Gender { get; set; }
}
