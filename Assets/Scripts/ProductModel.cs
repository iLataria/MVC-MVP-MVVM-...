using UnityEngine;

namespace MVCPractice.Models.Products
{
    public class Product
    {
        private readonly string id;
        private readonly string description;
        private readonly Sprite icon;

        public Product(string id, string description, Sprite icon)
        {
            this.id = id;
            this.icon = icon;
            this.description = description;
        }

        public string GetId() => id;
    }
}

