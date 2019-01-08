using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownBonus : MonoBehaviour {

    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }

        transform.position -= new Vector3(0, 4.0f * Time.deltaTime, 0);
    }
}
