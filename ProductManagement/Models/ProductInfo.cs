namespace ProductManagement.Models
{
    public class ProductInfo
    {
        public int Product_Id { get; set; }
        public int Category_Id { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImages { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime CreationDate { get; set; }
        public int ProductStatus { get; set; }

    }
}
