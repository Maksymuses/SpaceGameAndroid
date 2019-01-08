using UnityEngine;

public class Rotate : MonoBehaviour {

    public int rotateSpeed = 0;
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}