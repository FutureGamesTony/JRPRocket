using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoHeroCube : MonoHero
{
    HeroCube hero = null;
    private void Start()
    {
        hero = new HeroCube(gameObject);
    }
    public override void Attack(BattleAction battleAction, MonoEnemy enemy)
    {
        throw new System.NotImplementedException();
    }
    public override void Attack(BattleAction battleAction, MonoEnemy[] enemies)
    {
        throw new System.NotImplementedException();
    }

    public override void GetAttacked(BattleAction action)
    {
        throw new System.NotImplementedException();
    }

    public override void Attack(BattleAction battleAction, MonoHero Hero)
    {
        throw new System.NotImplementedException();
    }

    public override void Attack(BattleAction battleAction, MonoHero[] heroes)
    {
        throw new System.NotImplementedException();
    }

    public override void NextState()
    {
        hero.NextState();
    }

    public override BattleState SetState(BattleState newState)
    {
        return hero.SetState(newState);
    }

    public override BattleState GetState()
    {
        return hero.GetState();
    }
}
