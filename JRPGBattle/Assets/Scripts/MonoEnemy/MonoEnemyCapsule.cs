using UnityEngine;
public class MonoEnemyCapsule : MonoEnemy
{
    public override void GetAttacked(int damage)
    {
        displayDamage.fontSize = 72;
        displayDamage.text = damage.ToString();
    }
    private void Update()
    {
        displayDamage.enabled = GameManager.instance.GetHeroCapsule().displayText;

    }
}
