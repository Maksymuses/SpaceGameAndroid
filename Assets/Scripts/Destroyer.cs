using UnityEngine;

public class Destroyer : MonoBehaviour {
	void Update () {
        if (Pplayer.lose)
        {
            Destroy(gameObject);
        }
	}
}
