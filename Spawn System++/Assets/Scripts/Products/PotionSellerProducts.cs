using UnityEngine;
public class StrengthPotion : IProduct
{
    private readonly string _spritePath = "Sprites/strength potion";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}

public class HealingPotion : IProduct
{
    private readonly string _spritePath = "Sprites/healing potion";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class LovePotion : IProduct
{
    private readonly string _spritePath = "Sprites/love potion";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class CharismaPotion : IProduct
{
    private readonly string _spritePath = "Sprites/charisma potion";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Poison : IProduct
{
    private readonly string _spritePath = "Sprites/poison";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Pepto : IProduct
{
    private readonly string _spritePath = "Sprites/pepto";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
