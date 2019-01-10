using UnityEngine;

public class Bullet2 : MonoBehaviour {

    Rigidbody2D myRigidbody2D;
    public float moveSpeed;
    public GameObject BulletEffect;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myRigidbody2D.AddRelativeForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Asteroid")
        {
            if (other.GetComponent<AsteroidManager>() != null)
            {
                other.GetComponent<AsteroidManager>().TakeDamage(3);
                if (BulletEffect != null)
                {
                    Instantiate(BulletEffect, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }
        }
        if (other.tag == "Enemy" || other.tag == "Enemy5")
        {
            if (other.GetComponent<EnemyManager>() != null)
            {
                other.GetComponent<EnemyManager>().TakeDamageEnemy(2);
                if (BulletEffect != null)
                {
                    Instantiate(BulletEffect, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }
            if (other.GetComponent<EnemyManager2>() != null)
            {
                other.GetComponent<EnemyManager2>().TakeDamageEnemy(2);
                if (BulletEffect != null)
                {
                    Instantiate(BulletEffect, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }
            if (other.GetComponent<EnemyManager3>() != null)
            {
                other.GetComponent<EnemyManager3>().TakeDamageEnemy(2);
                if (BulletEffect != null)
                {
                    Instantiate(BulletEffect, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }
            if (other.GetComponent<EnemyManager4>() != null)
            {
                other.GetComponent<EnemyManager4>().TakeDamageEnemy(2);
                if (BulletEffect != null)
                {
                    Instantiate(BulletEffect, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }
            if (other.GetComponent<EnemyManager5>() != null)
            {
                other.GetComponent<EnemyManager5>().TakeDamageEnemy(2);
                if (BulletEffect != null)
                {
                    Instantiate(BulletEffect, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }
        }
    }
}