using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBossScene1 : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("BossFight1");
        Score.score = 0;
    }
}
