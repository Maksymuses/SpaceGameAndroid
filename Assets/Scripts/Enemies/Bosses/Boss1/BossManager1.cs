using UnityEngine;

public class BossManager1 : MonoBehaviour {

    private int Health = 30;
    public GameObject demolitionEffect;

    public static bool boss1Alive = true;

    public void TakeDamageEnemy(int damage)
    {
        Health = Health - damage;
        if (Health <= 0)
        {
            DieEnemy();
            boss1Alive = false;
            Score.score += 10000;
        }
    }

    public void DieEnemy()
    {
        if (demolitionEffect != null)
        {
            Instantiate(demolitionEffect, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }
}
