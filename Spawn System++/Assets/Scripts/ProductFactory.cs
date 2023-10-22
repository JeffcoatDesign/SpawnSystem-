using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductFactory : AbstractProductFactory
{
    IProductFactory _factory;
    ProductRequirements _requirements;

    public ProductFactory(ProductRequirements requirements)
    {
        _requirements = requirements;
        if (requirements.mercantType == MercantType.BlackSmith)
            _factory = new BlacksmithFactory();
        if (requirements.mercantType == MercantType.PotionSeller)
            _factory = new PotionFactory();
        if (requirements.mercantType == MercantType.Shopkeep)
            _factory = new ShopFactory();
    }
    public override IProduct Create()
    {
        return _factory.Create(_requirements);
    }
}
