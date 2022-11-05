using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New armor", menuName = "Eltara Custom Objects/ScriptableObjects/Items/Armor")]
public class Armor : Equipment
{
    [Header("Armor settings")]
    public int armor = 0;
    public ArmorType armorType = ArmorType.light;

    [Header("Attribute modifier settings")]
    public List<AttributeModifier> attributeModifiers = new ();

    public override void Equip (Character character) {
        throw new NotImplementedException();
    }
}