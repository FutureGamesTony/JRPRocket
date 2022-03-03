using UnityEngine;
public class MonoHeroCapsule : MonoHero
{
    HeroCapsule hero = null;
    public bool AttackAnimation;
    public bool displayText;
    private void Start()
    {
        hero = new HeroCapsule(gameObject);
        ButtonManager.buttonManager.activeHero = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            hero.ExecuteBattleAction();
    }
    public override void Attack(BattleAction battleAction, MonoEnemy enemy)
    {
        RegularAttack regularAttack = ScriptableObject.CreateInstance("RegularAttack") as RegularAttack;

        regularAttack.Init(hero, enemy);
        hero.AddBattleAction(regularAttack);
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
