using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProductFactory
{
    public IProduct Create(ProductRequirements requirements);
}
