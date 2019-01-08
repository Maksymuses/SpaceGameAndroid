using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour {
    void OnMouseDown()
    {
        SceneManager.LoadScene("ChooseShip");
    }
}
