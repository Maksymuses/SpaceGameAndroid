using UnityEngine;

public class EnemyManager2 : MonoBehaviour {

    private int Health = 2;
    public GameObject demolitionEffect;

    public void TakeDamageEnemy(int damage)
    {
        Health = Health - damage;
        if (Health <= 0)
        {
            DieEnemy();
            Score.score += 200;
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
