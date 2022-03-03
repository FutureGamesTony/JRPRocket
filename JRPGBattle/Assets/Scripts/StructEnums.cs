using System;

public enum BattleState : int
{
    ErrorState = -1,
    Idle = 0,
    Sleeping = 1,
    Selected = 2,
    Waiting = 3,
    Active = 4,
}
public enum Action : int
{
    ErrorAction = -1,
    NoAction = 0,
    Attack = 1,
    Magic = 2,
    Skill = 3,
    Item = 4,
}

public enum Element : int
{
    ErrorElement = -1,
    NonElemental = 0,
    FireElement = 1,
    IceElement = 2,
    WindElement = 3, 
    LightningElement = 4,
    LifeElement = 5,
    DeathElement = 6,

}
[Serializable]
public struct BattleTime
{
    public float timePassed;
    public float timeMax;
    public float timeIncrease;
}
[Serializable]
public struct AttackStruct
{
    public int attack;
}
[Serializable]
public struct MagicStruct
{
    public Magic spell;
    public bool isActive;
}

[Serializable]
public struct SkillStruct
{
    public Skill skill;
    
}

[Serializable]
public struct ItemStruct
{
    public Item item;
    public int amount;
}