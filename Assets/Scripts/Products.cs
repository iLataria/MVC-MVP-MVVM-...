using System;
using System.Collections.Generic;

namespace MVCPractice.Models
{
    public class Products
    {
        private List<Product> products;
        public Action<Product> OnProductRemoved;

        public Products(Product[] products)
        {
            this.products = new List<Product>();
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

        public List<Product> GetAll() => products;

        public void RemoveProduct(Product product)
        {
            if (products.Count == 0) return;
            products.Remove(product);
            OnProductRemoved.Invoke(product);
        }
    }
}

