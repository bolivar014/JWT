using JWT.Models;

namespace JWT.Constants
{
    public class ProductConstants
    {
        public static List<ProductsModel> Products = new List<ProductsModel>()
        {
            new ProductsModel() { Name = "Coca Cola", Description = "Bebida" },
            new ProductsModel() { Name = "Agua", Description = "Agua" }
        };
    }
}
