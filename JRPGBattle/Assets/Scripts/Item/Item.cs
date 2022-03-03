using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Item/Item")]
public class Item : BattleAction
{
    public int amountInInventory;
    public string attributeModifier;
    public int amountToModify;
    public Element itemElement;
    public override object Execute(Hero hero)
    {
        return null;
    }

    public override void Init(Hero hero, MonoEnemy enemy)
    {
        throw new System.NotImplementedException();
    }
}
