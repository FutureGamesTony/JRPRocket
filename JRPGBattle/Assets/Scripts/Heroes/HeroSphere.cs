using UnityEngine;
public class HeroSphere : Hero
{
    public HeroSphere(GameObject gameObject)
    {
        heroGameObject = gameObject;
    }

    public override void AddBattleAction(BattleAction action)
    {
        battleActions.Enqueue(action);
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
        throw new System.NotImplementedException();
    }
}
