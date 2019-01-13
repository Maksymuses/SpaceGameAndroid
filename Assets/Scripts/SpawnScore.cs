using System.Collections;
using UnityEngine;

public class SpawnScore : MonoBehaviour {

    public GameObject scoreObject;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Pplayer.lose && BossManager1.boss1Alive)
        {
            Instantiate(scoreObject, new Vector2(0, 5.5f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
