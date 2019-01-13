using UnityEngine;

public class TextDestroyAfterTime : MonoBehaviour
{

    private float delay = 2.0f;

    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            Destroy(gameObject);
        }
    }
}
