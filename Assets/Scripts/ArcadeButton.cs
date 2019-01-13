using UnityEngine;
using UnityEngine.SceneManagement;

public class ArcadeButton : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("GameScene");
    }
}
