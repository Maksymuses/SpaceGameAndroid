using UnityEngine;

public class EnemyExhaust : MonoBehaviour {

    public float exhaustDelay;
    private float exhaustDelayCounter;
    public GameObject exhaust;	

    
	void Update () {
        if (transform.position.y < EnemyBehaviour.rand)
        {
            Exhaust();
        }
	}

    private void Exhaust()
    {
        if (exhaustDelayCounter <= 0)
        {
            Instantiate(exhaust, new Vector2(transform.position.x, (transform.position.y + 0.531f)), transform.rotation);
            exhaustDelayCounter = exhaustDelay;
        }
        exhaustDelayCounter -= Time.deltaTime;
    }
}
