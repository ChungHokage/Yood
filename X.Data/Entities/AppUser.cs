using Microsoft.AspNetCore.Identity;

namespace X.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? DisplayName { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}