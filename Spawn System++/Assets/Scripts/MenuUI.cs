using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuUI : MonoBehaviour
{
    public TMP_Dropdown mercantDrop, actionDrop, goldDrop;
    public Client client;
    public Image itemImage;
    public Image itemshadow;
    private void Awake()
    {
        mercantDrop.onValueChanged.AddListener(SetMercant);
        actionDrop.onValueChanged.AddListener(SetAction);
        goldDrop.onValueChanged.AddListener(SetBudget);
        SetMercant(mercantDrop.value);
        SetAction(actionDrop.value);
        SetBudget(goldDrop.value);
    }
    private void SetMercant(int val)
    {
        client.mercant = (MercantType) val;
        UpdateClient();
    }
    private void SetAction(int val)
    {
        client.action = (PlayerAction)val;
        UpdateClient();
    }
    private void SetBudget(int val)
    {
        client.budge = val;
        UpdateClient();
    }
    private void UpdateClient()
    {
        IProduct product = client.CreateProduct();
        if (product.GetSprite() != null)
        {
            itemImage.sprite = product.GetSprite();
            itemshadow.sprite = product.GetSprite();
        }
    }
}
