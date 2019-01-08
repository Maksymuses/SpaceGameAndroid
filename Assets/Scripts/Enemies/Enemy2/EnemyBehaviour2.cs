using UnityEngine;

public class EnemyBehaviour2 : MonoBehaviour {

    public float shootDelay;
    private float shootDelayCounter;

    public GameObject bullet2Left;
    public GameObject bullet2Right;
    public GameObject demolitionEffect;

    void Update()
    {
        if (transform.position.y < 4.0f) {
            transform.position -= new Vector3(0, 1.8f * Time.deltaTime, 0);
            EnemyShoot();
        }
        if (transform.position.y > 4.0f)
        {
            transform.position -= new Vector3(0, 6.5f * Time.deltaTime, 0);
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
            if (FindObjectsOfType<Bullet>().Length < 8)
            {
                Instantiate(bullet2Left, new Vector2(transform.position.x - 0.051f, transform.position.y - 0.3245f), transform.rotation);
                Instantiate(bullet2Right, new Vector2(transform.position.x + 0.051f, transform.position.y - 0.3245f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
        }
        shootDelayCounter -= Time.deltaTime;
    }
}
