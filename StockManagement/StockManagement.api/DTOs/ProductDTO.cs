using StockManagement.api.Models;

namespace StockManagement.api.DTOs
{
    public class ProductDTO
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string FamilyId { get; set; } = null!;

        public string FamilyName { get; set; }
        public string Ean13code { get; set; }
        public string Obs { get; set; }


        public Product DtoToProductModel()
        {
            Product product = new Product
            {
                ProductId = this.ProductId,
                ProductName = this.ProductName,
                FamilyId = this.FamilyId,
                Ean13code = this.Ean13code,
                Obs = this.Obs
            };

            return product;

        }
        public ProductDTO ProductModelToDto(Product product)
        {
            ProductDTO dto = new ProductDTO
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                FamilyId = product.FamilyId,
                Ean13code = product.Ean13code,
                FamilyName = product.Family.FamilyName,
                Obs = product.Obs
            };

            return dto;

        }

    }
}