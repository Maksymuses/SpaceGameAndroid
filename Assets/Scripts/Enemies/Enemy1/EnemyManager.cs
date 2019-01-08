using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public int health;
    private int currentHealth;
    private int rand;
    private int sumScore;
    public GameObject demolitionEffect;

    void Start()
    {
        rand = Random.Range(1, 3);
        currentHealth = health + rand;
        sumScore = currentHealth;
    }

    public void TakeDamageEnemy(int damage)
    {
        currentHealth = currentHealth - damage;
        if (currentHealth <= 0)
        {
            DieEnemy();
            Score.score += 100 * sumScore;
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
