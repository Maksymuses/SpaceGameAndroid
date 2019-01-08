using UnityEngine;

public class EnemyBehaviour3 : MonoBehaviour {

    public float shootDelay;
    private float shootDelayCounter;

    public GameObject enemyBullet3;
    public GameObject target;
    public GameObject demolitionEffect;

    public float exhaustDelay;
    private float exhaustDelayCounter;
    public GameObject exhaust3;

    void Start()
    {
        target = GameObject.Find("Player");
    }

    void Update()
    {
        if (transform.position.y < 4.0f)
        {
            if (Pplayer.lose)
            {
                Instantiate(demolitionEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
                transform.up = -target.transform.position + transform.position;
                EnemyShoot();
        }
        if (transform.position.y > 4.0f)
        {
            transform.position -= new Vector3(0, 6.5f * Time.deltaTime, 0);
            Exhaust();
            if (Pplayer.lose)
            {
                Instantiate(demolitionEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }

    void EnemyShoot()
    {
        if (shootDelayCounter <= 0)
        {
            if (FindObjectsOfType<Bullet>().Length < 4)
            {
                Instantiate(enemyBullet3, new Vector2(transform.position.x + target.transform.position.x * 0.04f, transform.position.y - 0.3245f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
        }
        shootDelayCounter -= Time.deltaTime;
    }

    private void Exhaust()
    {
        if (exhaustDelayCounter <= 0)
        {
            Instantiate(exhaust3, new Vector2(transform.position.x, (transform.position.y + 0.468f)), transform.rotation);
            exhaustDelayCounter = exhaustDelay;
        }
        exhaustDelayCounter -= Time.deltaTime;
    }
}
