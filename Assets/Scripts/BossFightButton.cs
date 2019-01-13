using UnityEngine;
using UnityEngine.SceneManagement;

public class BossFightButton : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("BossFight1");
    }
}
