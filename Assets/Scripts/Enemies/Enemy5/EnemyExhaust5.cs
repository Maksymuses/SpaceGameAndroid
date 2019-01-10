using UnityEngine;

public class EnemyExhaust5 : MonoBehaviour {

    public float exhaustDelay;
    private float exhaustDelayCounter;
    public GameObject exhaust5;


    void Update()
    {
        Exhaust();
    }

    private void Exhaust()
    {
        if (exhaustDelayCounter <= 0)
        {
            Instantiate(exhaust5, new Vector2((transform.position.x - 0.005f), (transform.position.y + 0.329f)), transform.rotation);
            exhaustDelayCounter = exhaustDelay;
        }
        exhaustDelayCounter -= Time.deltaTime;
    }
}
