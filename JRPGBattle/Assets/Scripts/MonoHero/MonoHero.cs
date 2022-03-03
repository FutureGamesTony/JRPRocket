using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoHero : MonoBehaviour
{
    public BattleTime battleTime;
    public BattleAction battleAction;
    public MagicStruct magic;
    public SkillStruct skill;
    public ItemStruct item;
    public abstract void Attack(BattleAction battleAction, MonoEnemy enemy);
    public abstract void Attack(BattleAction battleAction, MonoHero Hero);
    public abstract void Attack(BattleAction battleAction, MonoEnemy[] enemies);
    public abstract void Attack(BattleAction battleAction, MonoHero[] heroes);
    public abstract void GetAttacked(BattleAction action);
    public abstract void NextState();
    public abstract BattleState SetState(BattleState newState);
    public abstract BattleState GetState();
}
