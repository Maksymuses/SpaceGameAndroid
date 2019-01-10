using UnityEngine;

public class EnemyExhaust4 : MonoBehaviour {

    public float exhaustDelay;
    private float exhaustDelayCounter;
    public GameObject exhaust4;


    void Update()
    {
        if (transform.position.y < EnemyBehaviour4.rand4)
        {
            Exhaust();
        }
    }

    private void Exhaust()
    {
        if (exhaustDelayCounter <= 0)
        {
            Instantiate(exhaust4, new Vector2(transform.position.x, (transform.position.y + 0.40647f)), transform.rotation);
            exhaustDelayCounter = exhaustDelay;
        }
        exhaustDelayCounter -= Time.deltaTime;
    }
}
