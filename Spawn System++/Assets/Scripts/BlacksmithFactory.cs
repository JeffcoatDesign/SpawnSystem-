using UnityEngine;
public class BlacksmithFactory : IProductFactory
{
    public IProduct Create (ProductRequirements requirements)
    {
        if (requirements.playerAction == PlayerAction.GoToBattle)
        {
            if (requirements.budget == 0)
                return new Knife();
            else if (requirements.budget == 2)
                return new Flail();
            else
                return new Sword();
        }
        else if (requirements.playerAction == PlayerAction.SeeTheKing)
        {
            if (requirements.budget == 0)
                return new Spear();
            else if (requirements.budget == 2)
                return new Scepter();
            else
                return new FineSpear();
        } else
        {
            if (requirements.budget == 0)
                return new Spear();
            else if (requirements.budget == 2)
                return new Scepter();
            else
                return new Sword();
        }
    }
}