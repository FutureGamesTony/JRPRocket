using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularAttack : Attack
{
    MonoEnemy enemy;
    public override void Init(Hero hero, MonoEnemy enemy)
    {
        this.enemy = enemy;

    }

    public override object Execute(Hero hero)
    {
        hero.DoAttack(enemy);

        return null;
    }

}
