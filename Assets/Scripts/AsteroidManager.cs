using UnityEngine;

public class AsteroidManager : MonoBehaviour {

    public int health;
    private int currentHealth;
    public GameObject demolitionEffect;

    void Start () {
        currentHealth = health;
	}
	
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        if(currentHealth <= 0)
        {
            Die();
            Score.score += 10;
        }
    }

    public void Die()
    {
        if(demolitionEffect != null)
        {
            Instantiate(demolitionEffect, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }
}
