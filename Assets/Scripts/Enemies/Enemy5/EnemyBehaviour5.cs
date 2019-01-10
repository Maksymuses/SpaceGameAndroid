using UnityEngine;

public class EnemyBehaviour5 : MonoBehaviour {

    public GameObject demolitionEffect;

    void Update()
    {
        transform.position -= new Vector3(0, 5.5f * Time.deltaTime, 0);
        if (Pplayer.lose)
        {
            Instantiate(demolitionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
