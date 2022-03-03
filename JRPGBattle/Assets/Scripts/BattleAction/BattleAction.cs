using UnityEngine;

public abstract class BattleAction : ScriptableObject
{
    public Vector3 offsetToTarget;
    public abstract void Init(Hero hero, MonoEnemy enemy);
    public abstract object Execute(Hero hero);

}
