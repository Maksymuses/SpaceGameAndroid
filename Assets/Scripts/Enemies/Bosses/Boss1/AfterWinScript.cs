using UnityEngine;

public class AfterWinScript : MonoBehaviour
{

    public GameObject restart;
    public GameObject QuitGame;
    public GameObject MainMenu;

    private float delay = 2.0f;

    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            Instantiate(restart, new Vector2(0, 3.23f), transform.rotation);
            Instantiate(QuitGame, new Vector2(0, -1.73f), transform.rotation);
            Instantiate(MainMenu, new Vector2(0, 0.64f), transform.rotation);
            AssistantsManager1.deathCounter = 0;
            BossManager1.boss1Alive = true;
            Destroy(gameObject);
        }
    }
}
