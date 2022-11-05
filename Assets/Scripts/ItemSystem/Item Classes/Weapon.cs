using System;
using System.Collections.Generic;

public class Weapon : Equipment
{
    public int healthDamage = 0;
    public int armorPierce = 0;

    public int blockValue = 0;

    public List<AttackEffect> attackEffects = new ();
    public List<AttributeModifier> attributeModifiers = new ();

    public override void Equip (Character character) {
        throw new NotImplementedException();
    }
}