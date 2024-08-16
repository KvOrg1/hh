using hh.Domain.Commons;

namespace hh.Domain.Entities.Addresses;

public class Address : Auditable
{
    public string StreetName { get; set; }
    public string RegionName { get; set; }
    public string HomeName { get; set; }
    public string DistrictName { get; set; }

}
