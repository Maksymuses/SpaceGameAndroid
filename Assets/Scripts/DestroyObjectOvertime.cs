using System.Collections;
using UnityEngine;

public class DestroyObjectOvertime : MonoBehaviour {

    public float timeToDie;

	void Update () {
		if(timeToDie <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            timeToDie -= Time.deltaTime;
        }
	}
}
