public abstract class Equipment : Item, IEquipable
{
    public EquipmentSlot slot = EquipmentSlot.mainHand;

    public abstract void Equip (Character character);
}