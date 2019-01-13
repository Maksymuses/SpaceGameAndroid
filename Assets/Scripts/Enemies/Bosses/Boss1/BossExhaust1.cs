using UnityEngine;

public class BossExhaust1 : MonoBehaviour {

    public float exhaustDelay;
    private float exhaustDelayCounter;
    public GameObject bossExhaust1;

    void Update()
    {
        Exhaust();
    }

    private void Exhaust()
    {
        if (exhaustDelayCounter <= 0)
        {
            Instantiate(bossExhaust1, new Vector2(transform.position.x + 0.189f, (transform.position.y + 0.602f)), transform.rotation);
            Instantiate(bossExhaust1, new Vector2(transform.position.x - 0.189f, (transform.position.y + 0.602f)), transform.rotation);
            exhaustDelayCounter = exhaustDelay;
        }
        exhaustDelayCounter -= Time.deltaTime;
    }
}
