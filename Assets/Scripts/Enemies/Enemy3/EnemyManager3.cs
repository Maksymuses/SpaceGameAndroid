using UnityEngine;

public class EnemyManager3 : MonoBehaviour {

    private int Health = 3;
    public GameObject demolitionEffect;

    public void TakeDamageEnemy(int damage)
    {
        Health = Health - damage;
        if (Health <= 0)
        {
            DieEnemy();
            Score.score += 300;
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
