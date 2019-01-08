using System.Collections;
using UnityEngine;

public class MoveBackground : MonoBehaviour {

    public GameObject background;

    void Start()
    {
        StartCoroutine(SpawnBG());
    }

    IEnumerator SpawnBG()
    {
        while (!Pplayer.lose) {
            Instantiate(background, new Vector2(0f, 27f), Quaternion.identity);
            yield return new WaitForSeconds(20.0f);
        }
    }
}
