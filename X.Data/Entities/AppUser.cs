using Microsoft.AspNetCore.Identity;

namespace X.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? DisplayName { get; set; }
        public DateTime CreatedTime { get; set; }
        public Cart Cart { get; set; }
        public List<Address>? Addresses { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public UserInformation UserInformation { get; set; }
    }
}