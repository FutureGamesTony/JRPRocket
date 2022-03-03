using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : StateMachineBehaviour
{

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AnimationTime(stateInfo.length, animator);
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("Attack", GameManager.instance.monoCapsule.AttackAnimation);

    }

    IEnumerator AnimationTime(float timer, Animator animator)
    {
        yield return new WaitForSeconds(timer);
        animator.SetBool("Attack", false);
        animator.SetBool("MoveForAttack", false);

    }
}
