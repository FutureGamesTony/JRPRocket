using UnityEngine;
using TMPro;
using System.Collections;
public class AnimationManager : MonoBehaviour
{
    public static AnimationManager animationManager;
    public RuntimeAnimatorController heroCapsuleController;
    public Animator heroCapsuleAnimator;
    public TextMeshProUGUI capsuleText;
    bool displayText = false;
    private void OnEnable()
    {
        animationManager = this;

    }
    public void SetDamage(int damage)
    {
        displayText = true;
        capsuleText.gameObject.SetActive(displayText);
        capsuleText.text = damage.ToString();
        StartCoroutine(DisplayText(2));
    }
    
    IEnumerator DisplayText(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        capsuleText.gameObject.SetActive(false);
        heroCapsuleAnimator.SetBool("Attack", false);
    }
}
