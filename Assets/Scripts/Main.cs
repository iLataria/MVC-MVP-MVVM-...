using MVCPractice.Models.Products;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] Transform uiParent;
    [SerializeField] ProductsScreenView uiView;

    public List<Product> productModelList;
    private Products productsModel;

    void Start()
    {
        productsModel = new Products(productModelList.ToArray());
        var productScreenView = Instantiate(uiView, uiParent);
        productScreenView.Init(productsModel);
    }

    public Products GetProductsModel() => productsModel;
}
