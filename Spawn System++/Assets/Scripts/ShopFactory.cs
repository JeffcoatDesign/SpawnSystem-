using UnityEngine;
public class ShopFactory : IProductFactory
{
    public IProduct Create (ProductRequirements requirements)
    {
        if (requirements.playerAction == PlayerAction.GoToBattle)
        {
            if (requirements.budget == 1)
            {
                return new Bow();
            }
            else if (requirements.budget == 2)
            {
                return new Bomb();
            }
            else return new Arrows();
        }
        else if (requirements.playerAction == PlayerAction.SeeTheKing)
        {
            if (requirements.budget == 1)
            {
                return new Fruit();
            }
            else if (requirements.budget == 2)
            {
                return new Gold();
            }
            else return new Flower();
        }
        else if (requirements.budget == 0)
            return new Flower();
        else
            return new Rope();
    }
}