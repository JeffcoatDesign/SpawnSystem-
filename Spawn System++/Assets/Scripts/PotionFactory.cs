using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionFactory : IProductFactory
{
    public IProduct Create(ProductRequirements requirements)
    {
        if (requirements.playerAction == PlayerAction.GoToBattle)
        {
            if (requirements.budget == 0)
                return new Poison();
            else if (requirements.budget == 2)
                return new StrengthPotion();
            else
                return new HealingPotion();
        }
        else if (requirements.playerAction == PlayerAction.SeeTheKing)
        {
            if (requirements.budget == 0)
                return new Pepto();
            else if (requirements.budget == 2)
                return new LovePotion();
            else
                return new CharismaPotion();
        }
        else
        {
            if (requirements.budget == 0)
                return new Poison();
            else if (requirements.budget == 2)
                return new LovePotion();
            else
                return new HealingPotion();
        }
    }
}
