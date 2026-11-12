using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack;
    public int defense;
    public bool isCritical;
    public bool targetIsBoss;

    [ContextMenu("데미지")]
    public void Calc()
    {
        int damage = attack - defense;
        if (damage < 1)
        {
            damage = 1;
        }
        if (isCritical)
        {
            damage *= 2;
        }
        if (targetIsBoss)
        {
            damage /= 2;
        }
        Debug.Log(damage);
    }
}