using TMPro;
using UnityEngine;

public abstract class MonoEnemy : MonoBehaviour
{
    public TextMeshProUGUI displayDamage;
    public abstract void GetAttacked(int damage);
}
