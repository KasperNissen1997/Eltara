using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New weapon", menuName = "Eltara Custom Objects/ScriptableObjects/Items/Weapon")]
public class Weapon : Equipment
{
    [Header("Offensive weapon settings")]
    public int healthDamage = 0;
    public int armorPierce = 0;

    [Header("Defensive weapon settings")]
    public int blockValue = 0;

    [Header("Attack effect settings")]
    public List<AttackEffect> attackEffects = new ();

    [Header("Attribute modifier settings")]
    public List<AttributeModifier> attributeModifiers = new ();

    public override void Equip (Character character) {
        throw new NotImplementedException();
    }
}