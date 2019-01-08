using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public static int score = 0;

    public void PlayerScored(int newScoreValue)
    {
        score += newScoreValue;
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Score")
        {
            PlayerScored(1);
        }
    }
}
