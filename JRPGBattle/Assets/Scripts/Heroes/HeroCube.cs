using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCube : Hero
{
    public HeroCube(GameObject gameObject)
    {
        heroGameObject = gameObject;
    }

    public override void AddBattleAction(BattleAction action)
    {
        throw new System.NotImplementedException();
    }

    public override void DoAttack(MonoEnemy enemy)
    {
        throw new System.NotImplementedException();
    }

    public override void ExecuteBattleAction()
    {
        throw new System.NotImplementedException();
    }

    public override BattleState GetState()
    {
        throw new System.NotImplementedException();
    }

    public override void NextState()
    {
        if (battleState == BattleState.Active)
            battleState = BattleState.ErrorState;

        battleState++;
    }

    public override BattleState SetState(BattleState newState)
    {
        battleState = newState;
        return battleState;
    }
}
