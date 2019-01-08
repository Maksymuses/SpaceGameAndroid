using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	void OnMouseDown()
    {
        SceneManager.LoadScene("GameScene");
        Score.score = 0;
    }
}
