using UnityEngine;

public class FallDownBackground : MonoBehaviour {

    [SerializeField]
    private float fallSpeed = 3f;

    void Update()
    {
        if (transform.position.y < -20f)
        {
            Destroy(gameObject);
        }
        if (!Pplayer.lose)
        {
            transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
        }
    }
}
