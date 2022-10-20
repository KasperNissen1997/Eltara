using UnityEngine;

public interface IItem
{
    public string Name { get; set; }
    public string Description { get; set; }

    public int Value { get; set; }
    public RarityLevel Rarity { get; set; }

    public int Height { get; set; }
    public int Width { get; set; }
    public int MaxStack { get; set; }
}
