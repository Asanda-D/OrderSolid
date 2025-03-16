
namespace OrderSolid.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}