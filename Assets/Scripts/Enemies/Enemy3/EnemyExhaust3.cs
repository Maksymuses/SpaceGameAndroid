using UnityEngine;

public class EnemyExhaust3 : MonoBehaviour {

    public float exhaustDelay;
    private float exhaustDelayCounter;
    public GameObject exhaust3;

    void Update()
    {
        Exhaust();
    }

    private void Exhaust()
    {
        if (exhaustDelayCounter <= 0)
        {
            Instantiate(exhaust3, new Vector2(transform.position.x, (transform.position.y + 0.468f)), transform.rotation);
            exhaustDelayCounter = exhaustDelay;
        }
        exhaustDelayCounter -= Time.deltaTime;
    }
}
