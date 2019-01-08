using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    public float shootDelay;
    private float shootDelayCounter;

    private int trigger = 0;
    public static float rand;

    public GameObject bullet;
    public GameObject demolitionEffect;

    void Start()
    {
        rand = Random.Range(3.5f, 4.5f);
        if (rand > 4.0f) //change direction of enemy moving
        {
            trigger = 0;
        }
        if (rand < 4.0f)
        {
            trigger = 1;
        }
    }

    void Update()
    {
        if (transform.position.y < rand)
        {
            if (trigger == 0)
            {
                transform.position += new Vector3(1.5f * Time.deltaTime, -1.0f * Time.deltaTime, 0);
                EnemyShoot();
                if (transform.position.x > 2.0f)
                {
                    trigger = 1;
                }
            }
            if (trigger == 1)
            {
                transform.position -= new Vector3(1.5f * Time.deltaTime, 1.0f * Time.deltaTime, 0);
                EnemyShoot();
                if (transform.position.x < -2.0f)
                {
                    trigger = 0;
                }
            }
        }
        if (transform.position.y > rand)
        {
            transform.position -= new Vector3(0, 4.5f * Time.deltaTime, 0);
            if (Pplayer.lose)
            {
                Instantiate(demolitionEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        if (transform.position.y < -6f)
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
                Instantiate(bullet, new Vector2(transform.position.x, transform.position.y - 0.394f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
        }
        shootDelayCounter -= Time.deltaTime;
    }
}