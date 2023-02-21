using System.Collections.Generic;
using UnityEngine;
using MVCPractice.Models.Products;
using TMPro;
using System.Linq;

public class ProductsScreenView : MonoBehaviour
{
    [SerializeField] private Transform productsParent;
    [SerializeField] private TextMeshProUGUI descPanel;
    [SerializeField] private ProductView productViewPrefab;

    public Dictionary<Product, ProductView> dic = new Dictionary<Product, ProductView>();
    private Products products;

    private void Start()
    {
        SpawnProductViews();
        SubscribeToProductViewsOnClick();
        products.modelChanged += OnModelChanged;
    }

    private void SpawnProductViews()
    {
        foreach (var product in products.GetAll())
        {
            ProductView view = Instantiate(productViewPrefab, productsParent);
            view.Init(product);
            dic.Add(product, view);
        }
    }

    private void SubscribeToProductViewsOnClick()
    {
        foreach (var product in products.GetAll())
        {
            foreach (var productAndProductViewPair in dic)
            {
                productAndProductViewPair.Value.OnCliCk(OnProductViewClicked);
            }
        }
    }

    private void OnProductViewClicked(ProductView productView)
    {
        UpdateProductDescription(productView);
    }

    private void UpdateProductDescription(ProductView productView)
    {
        descPanel.text = productView.GetDescription();
    }

    public void Init(Products products)
    {
        this.products = products;
    }

    void OnModelChanged(Product p)
    {
        dic.TryGetValue(p, out ProductView view);
        Destroy(view.gameObject);

        dic.Remove(p);
        descPanel.text = "";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dic.Count == 0) return;
            KeyValuePair<Product, ProductView> p = dic.First();
            products.RemoveProduct(p.Key);
        }
    }
}
