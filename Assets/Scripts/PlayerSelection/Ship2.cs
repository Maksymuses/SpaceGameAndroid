using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship2 : MonoBehaviour {
    public static bool ship2 = false;
    void OnMouseDown()
    {
        ship2 = true;
        SceneManager.LoadScene("GameScene");
    }
}
