using UnityEngine;

public abstract class Item : ScriptableObject
{
    [Header("Item settings")]
    public string name = "Insert item name here.";
    public string description = "Insert item description here.";
    public Sprite sprite;

    [Space(10)]
    public int value = 0;
    public RarityLevel rarity = RarityLevel.junk;

    [Header("Inventory settings")]
    public int width = 1;
    public int height = 1; 
    public int maxStack = 1;
}