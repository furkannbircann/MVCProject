using MVCProject.Web.Models.Entities.Concrete;

namespace MVCProject.Web.Models.DataAccess
{
    public class ProductRepository
    {
        private static List<Product> _products;
        public List<Product> GetAllProducts() => _products;
        public void ProductAdd(Product product) => _products.Add(product);

        public void ProductDelete(Product product)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (hasProduct == null)
            {
                throw new Exception("Product not found");
            }
            _products.Remove(hasProduct);
        }

        public void ProductUpdate(Product product)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (hasProduct == null)
            {
                throw new Exception("Product not found");
            }
            hasProduct.Name = product.Name;
            hasProduct.Price = product.Price;
            hasProduct.Stock = product.Stock;

            var index = _products.FindIndex(p => p.Id == product.Id);
            _products[index] = hasProduct;
        }
    }
}

