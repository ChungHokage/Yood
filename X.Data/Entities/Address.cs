using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Data.Enum;

namespace X.Data.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Commune { get; set; }
        public AddressType AddressType { get; set; }
        public bool isDefault { get; set; }
        public AppUser User { get; set; }
    }
}