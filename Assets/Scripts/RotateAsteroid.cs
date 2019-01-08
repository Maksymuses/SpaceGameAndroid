using UnityEngine;

public class RotateAsteroid : MonoBehaviour
{
    private float rand;

    void Start()
    {
        rand = Random.Range(25.0f, 500.0f);
    }

    void Update()
    {
        transform.Rotate(0, 0, rand * Time.deltaTime);
    }
}
