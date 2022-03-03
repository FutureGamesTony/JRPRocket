using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public AnimationManager animationManager;
    public MonoHero[] monoHeroes;
    public MonoHeroCapsule monoCapsule;

    private void OnEnable()
    {
        instance = this;
    }
    public MonoHeroCapsule GetHeroCapsule()
    {
        return monoCapsule;
    }
}
