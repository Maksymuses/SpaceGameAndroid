using UnityEngine;

public class EnemyBehaviour4 : MonoBehaviour {
    public float shootDelay;
    private float shootDelayCounter;

    private int trigger = 0;
    public static float rand4;

    public GameObject enemyBullet4;
    public GameObject demolitionEffect;

    void Start()
    {
        rand4 = Random.Range(1.5f, 3.0f);
        if (rand4 > 2.25f) //change direction of enemy moving
        {
            trigger = 0;
        }
        if (rand4 < 2.25f)
        {
            trigger = 1;
        }
    }

    void Update()
    {
        if (transform.position.y < rand4)
        {
            if (trigger == 0)
            {
                transform.position += new Vector3(2.5f * Time.deltaTime, 0, 0);
                EnemyShoot();
            }
            if (trigger == 1)
            {
                transform.position -= new Vector3(2.5f * Time.deltaTime, 0, 0);
                EnemyShoot();
            }
        }
        if (transform.position.y > rand4)
        {
            transform.position -= new Vector3(0, 8.5f * Time.deltaTime, 0);
            if (Pplayer.lose)
            {
                Instantiate(demolitionEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        if (transform.position.x < -6f || transform.position.x > 6f)
        {
            Destroy(gameObject);
        }
    }

    void EnemyShoot()
    {
        if (shootDelayCounter <= 0)
        {
            if (FindObjectsOfType<Bullet>().Length < 4)
            {
                Instantiate(enemyBullet4, new Vector2(transform.position.x, transform.position.y - 0.394f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
        }
        shootDelayCounter -= Time.deltaTime;
    }
}