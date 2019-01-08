using UnityEngine;

public class EnemyExhaust2 : MonoBehaviour {

    public float exhaustDelay;
    private float exhaustDelayCounter;
    public GameObject exhaust2;

    void Update()
    {
        if (transform.position.y < 4.0f)
        {
            Exhaust();
        }
    }

    private void Exhaust()
    {
        if (exhaustDelayCounter <= 0)
        {
            Instantiate(exhaust2, new Vector2(transform.position.x, (transform.position.y + 0.33f)), transform.rotation);
            exhaustDelayCounter = exhaustDelay;
        }
        exhaustDelayCounter -= Time.deltaTime;
    }
}
