using hh.Domain.Commons;

namespace hh.Domain.Entities.Users;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PaswordHash { get; set; }
    public string Email { get; set; }
    public Guid AddressId { get; set; }
}
