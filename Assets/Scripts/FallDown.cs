using UnityEngine;

public class FallDown : MonoBehaviour {

    private float randY;
    private float randX;

    void Start()
    {
        randY = Random.Range(1.0f, 4.0f);
        randX = Random.Range(-0.4f, 0.4f);
    }

	void Update () {
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(randX * Time.deltaTime, randY * Time.deltaTime, 0);
	}
}
