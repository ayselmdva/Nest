namespace Nest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
