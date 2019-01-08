using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship1 : MonoBehaviour {
    public static bool ship1 = false;
    void OnMouseDown()
    {
        ship1 = true;
        SceneManager.LoadScene("GameScene");
    }
}
