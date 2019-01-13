using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship3 : MonoBehaviour {
    public static bool ship3 = false;
    void OnMouseDown()
    {
        ship3 = true;
        SceneManager.LoadScene("ChooseGame");
    }
}
