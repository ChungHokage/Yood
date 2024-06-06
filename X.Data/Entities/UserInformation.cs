using X.Data.Enum;

namespace X.Data.Entities
{
    public class UserInformation
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public AppUser AppUser { get; set; }
    }
}