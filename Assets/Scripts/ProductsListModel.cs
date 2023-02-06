using System.Collections.Generic;

namespace MVCPractice.Models.Products
{
    public class ProductsListModel
    {
        private List<ProductModel> productsList;

        public ProductsListModel(ProductModel[] productsList)
        {
            this.productsList.AddRange(productsList);
        }

        public ProductModel GetProductById(string id)
        {
            for (int i = 0; i < productsList.Count; i++)
            {
                string currentIterationProductId = productsList[i].GetId();
                if (currentIterationProductId == id)
                {
                    return productsList[i];
                }
            }

            return null;
        }
    }
}

