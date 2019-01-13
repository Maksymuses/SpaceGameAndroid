using UnityEngine;

public class BossBehaviour1 : MonoBehaviour {

    public float shootDelay;
    private float shootDelayCounter;

    public GameObject bossBullet1_1;
    public GameObject bossBullet1_2;
    public GameObject bossBullet1_2_Right;
    public GameObject demolitionEffect;

    void Update()
    {
        if (transform.position.y < 4.0f)
        {
            EnemyShoot();
        }
        if (transform.position.y > 4.0f)
        {
            transform.position -= new Vector3(0, 6.5f * Time.deltaTime, 0);
        }
    }

    void EnemyShoot()
    {
        if (shootDelayCounter <= 0)
        {
            if (FindObjectsOfType<Bullet>().Length < 4)
            {
                Instantiate(bossBullet1_1, new Vector2(transform.position.x + 0.14f, transform.position.y - 0.136f), transform.rotation);
                Instantiate(bossBullet1_1, new Vector2(transform.position.x - 0.14f, transform.position.y - 0.136f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
        }
        shootDelayCounter -= Time.deltaTime;
        if (shootDelayCounter <= 0)
        {
            if (FindObjectsOfType<Bullet>().Length < 4)
            {
                Instantiate(bossBullet1_2_Right, new Vector2(transform.position.x + 0.37f, transform.position.y - 0.054f), transform.rotation);
                Instantiate(bossBullet1_2, new Vector2(transform.position.x - 0.37f, transform.position.y - 0.054f), transform.rotation);
                shootDelayCounter = shootDelay;
            }
        }
        shootDelayCounter -= Time.deltaTime;
    }
}