using UnityEngine;
using UnityEditor;
public class Rope : IProduct
{
    private readonly string _spritePath = "Sprites/rope";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Arrows : IProduct
{
    private readonly string _spritePath = "Sprites/arrows";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Bow : IProduct
{
    private readonly string _spritePath = "Sprites/bow";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Bomb : IProduct
{
    private readonly string _spritePath = "Sprites/bomb";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Flower : IProduct
{
    private readonly string _spritePath = "Sprites/flower";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Fruit : IProduct
{
    private readonly string _spritePath = "Sprites/fruit";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}
public class Gold : IProduct
{
    private readonly string _spritePath = "Sprites/gold";
    public Sprite GetSprite()
    {
        Sprite sprite = Resources.Load<Sprite>(_spritePath);
        return sprite;
    }
}