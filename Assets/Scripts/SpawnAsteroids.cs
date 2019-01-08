using System.Collections;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour {

    public GameObject asteroid;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Pplayer.lose)
        {
            Instantiate(asteroid, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(3.5f);
        }
    }
}