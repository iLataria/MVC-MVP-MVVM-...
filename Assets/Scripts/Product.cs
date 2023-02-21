using System;
using UnityEngine;

namespace MVCPractice.Models.Products
{
    [Serializable]
    public class Product
    {
        [SerializeField] private string id;
        [SerializeField] private string description;
        [SerializeField] private Sprite icon;

        public string GetId() => id;
        public Sprite GetIcon() => icon;
        public string GetDescription() => description;
    }
}

