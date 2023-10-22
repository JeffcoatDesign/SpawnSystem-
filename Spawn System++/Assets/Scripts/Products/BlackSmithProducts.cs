using UnityEngine;
public class Sword : IProduct
{
    private readonly string _spritePath = "Sprites/sword";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Knife : IProduct
{
    private readonly string _spritePath = "Sprites/knife";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Flail : IProduct
{
    private readonly string _spritePath = "Sprites/flail";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Spear : IProduct
{
    private readonly string _spritePath = "Sprites/spear";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class FineSpear : IProduct
{
    private readonly string _spritePath = "Sprites/finespear";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Scepter : IProduct
{
    private readonly string _spritePath = "Sprites/scepter";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}