public abstract class Equipment : IEquipable
{
    public EquipmentSlot slot = EquipmentSlot.mainHand;

    public abstract void Equip (Character character);
}