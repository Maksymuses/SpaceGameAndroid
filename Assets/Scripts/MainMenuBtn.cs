using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBtn : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
        Score.score = 0;
        Ship1.ship1 = false;
        Ship2.ship2 = false;
        Ship3.ship3 = false;
    }
}
