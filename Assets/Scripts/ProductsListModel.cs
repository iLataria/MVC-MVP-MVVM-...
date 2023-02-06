using System.Collections.Generic;

namespace MVCPractice.Models.Products
{
    public class Products
    {
        private List<Product> products;

        public Products(Product[] products)
        {
            this.products.AddRange(products);
        }

        public Product Get(string productId)
        {
            for (int i = 0; i < products.Count; i++)
            {
                string currentIterationProductId = products[i].GetId();
                if (currentIterationProductId == productId)
                {
                    return products[i];
                }
            }

            return null;
        }
    }
}

