using UnityEngine;

public class AssistantsManager1 : MonoBehaviour {

    private int Health = 3;
    private float immortalityDelay = 0.1f;
    public GameObject demolitionEffect;
    public GameObject immortalitySkin;
    public GameObject youWinText;

    public static int deathCounter = 0;

    void Update()
    {
        if (BossManager1.boss1Alive)
        {
            Instantiate(immortalitySkin, transform.position, transform.rotation);
            immortalityDelay -= Time.deltaTime;
            Health = 3;
        }
    }

    public void TakeDamageEnemy(int damage)
    {
        if (!BossManager1.boss1Alive)
        {
            Health = Health - damage;
            if (Health <= 0)
            {
                DieEnemy();
                deathCounter++;
                Score.score += 300;
                if(deathCounter == 2)
                {
                    Instantiate(youWinText, new Vector2(0, 1.46f), Quaternion.identity);
                }
            }
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
