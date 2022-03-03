using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero 
{
    protected GameObject heroGameObject;
    protected Queue<BattleAction> battleActions = new Queue<BattleAction>();
    public BattleState battleState;
    public abstract void AddBattleAction(BattleAction action);
    public abstract void ExecuteBattleAction();
    public abstract void DoAttack(MonoEnemy enemy);
    public abstract BattleState GetState();
    public abstract void NextState();
    public abstract BattleState SetState(BattleState newState);    
    protected void Attack(MonoEnemy enemy)
    {
        AnimationManager animationManager = AnimationManager.animationManager; 
        // This could be fixed by setting different variables and values. It could either be
        // set on the individual heroes or have arguments that gets the correct hero and
        // enemy to manipulate. 
        animationManager.heroCapsuleAnimator.SetBool("MoveForAttack", true);
        // magic value, can be replaced with damage calculations.
        animationManager.SetDamage(100);
        enemy.GetAttacked(100);

    }
}
