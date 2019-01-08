using UnityEngine;

public class ScoreSpeed : MonoBehaviour {
    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, 3.0f * Time.deltaTime, 0);
    }
}
