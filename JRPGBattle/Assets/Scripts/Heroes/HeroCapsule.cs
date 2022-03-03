using UnityEngine;
public class HeroCapsule : Hero
{

    public HeroCapsule(GameObject gameObject)
    {
        heroGameObject = gameObject;
    }

    public override void AddBattleAction(BattleAction action)
    {
        battleActions.Enqueue(action);
    }

    public override void DoAttack(MonoEnemy enemy)
    {
        Attack(enemy);
    }

    public override void ExecuteBattleAction()
    {
        if (battleActions.Count == 0)
            return;
        foreach (BattleAction action in battleActions)
            action.Execute(this);
        battleActions.Clear();
    }

    public override BattleState GetState()
    {
        return battleState;
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
