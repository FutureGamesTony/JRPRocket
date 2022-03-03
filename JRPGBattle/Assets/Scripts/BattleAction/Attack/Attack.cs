using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "AttackType/Attack")]
public class Attack : BattleAction
{
    public override void Init(Hero hero, MonoEnemy enemy)
    {
        throw new System.NotImplementedException();
    }


    public float attackModifier;
    public override object Execute(Hero obj)
    {
        AttackAction(obj);
        return null;
    }

    void AttackAction (Hero hero)
    {

    }
}
