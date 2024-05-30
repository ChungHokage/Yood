using X.Data.Enum;

namespace X.Data.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public PaymentType PaymentMethod { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TransportFee { get; set; }
        public decimal Promotion { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}