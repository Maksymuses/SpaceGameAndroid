using UnityEngine;

public class RotateShipMainMenu : MonoBehaviour {
    void Update()
    {
        transform.Rotate(0, 0, 20.0f*Time.deltaTime);
    }
}
