using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody2D myRigidbody2D;
    public float moveSpeed;

	void Start () {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myRigidbody2D.AddRelativeForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);
	}
	
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Asteroid")
        {
            if(other.GetComponent<AsteroidManager>() != null)
            {
                other.GetComponent<AsteroidManager>().TakeDamage(1);
                Destroy(gameObject);
            }
        }
        if (other.tag == "Enemy")
        {
            if (other.GetComponent<EnemyManager>() != null)
            {
                other.GetComponent<EnemyManager>().TakeDamageEnemy(1);
                Destroy(gameObject);
            }
            if (other.GetComponent<EnemyManager2>() != null)
            {
                other.GetComponent<EnemyManager2>().TakeDamageEnemy(1);
                Destroy(gameObject);
            }
            if (other.GetComponent<EnemyManager3>() != null)
            {
                other.GetComponent<EnemyManager3>().TakeDamageEnemy(1);
                Destroy(gameObject);
            }
        }
    }
}
