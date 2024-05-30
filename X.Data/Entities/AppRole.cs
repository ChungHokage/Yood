using Microsoft.AspNetCore.Identity;

namespace X.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}