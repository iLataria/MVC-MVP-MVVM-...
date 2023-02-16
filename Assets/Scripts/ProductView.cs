using MVCPractice.Models.Products;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProductView : MonoBehaviour
{
    [SerializeField] private Image imgComp;
    private Button btn;
    private Action<ProductView> onBtnClicked;

    private string id;
    private string description;
    private Sprite icon;

    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => onBtnClicked.Invoke(this));
    }

    public void Init(Product product)
    {
        id = product.GetId();
        description = product.GetDescription();
        icon = product.GetIcon();

        imgComp.sprite = icon;
    }

    public void OnCliCk(Action<ProductView> del)
    {
        onBtnClicked += del;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetId()
    {
        return id;
    }
}
