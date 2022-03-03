using UnityEngine;

[CreateAssetMenu(fileName = "Magic", menuName = "Magic/Spell")]
public class Magic : BattleAction
{
    public Element element;
    public int MPCost;

    public override object Execute(Hero hero)
    {
        throw new System.NotImplementedException();
    }

    public override void Init(Hero hero, MonoEnemy enemy)
    {
        throw new System.NotImplementedException();
    }
}
