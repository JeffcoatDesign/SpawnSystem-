using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public PlayerAction action;
    public MercantType mercant;
    public int budge;

    public IProduct CreateProduct()
    {
        var requirements = new ProductRequirements
        {
            mercantType = mercant,
            playerAction = action,
            budget = budge
        };

        var product = GetProduct(requirements);

        Debug.Log(product.GetType().Name);
        return product;
    }
    private static IProduct GetProduct(ProductRequirements requirements)
    {
        var factory = new ProductFactory(requirements);
        return factory.Create();
    }
}
