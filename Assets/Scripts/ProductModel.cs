using UnityEngine;

namespace MVCPractice.Models.Products
{
    public class ProductModel
    {
        private string id;
        private string description;
        private Sprite icon;

        public ProductModel(string id, string description, Sprite icon)
        {
            this.id = id;
            this.icon = icon;
            this.description = description;
        }

        public string GetId() => id;
    }
}

