using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton2 : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("ChooseShip");
    }
}