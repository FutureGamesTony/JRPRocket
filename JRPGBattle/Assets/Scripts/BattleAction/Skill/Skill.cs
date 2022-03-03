using UnityEngine;
[CreateAssetMenu(fileName = "Skill", menuName = "Skill/Skill")]
public class Skill : BattleAction
{
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
