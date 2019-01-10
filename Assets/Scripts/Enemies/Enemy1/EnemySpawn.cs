using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    private float increaseSpawn = 0;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (!Pplayer.lose)
        {
            yield return new WaitForSeconds(7.0f - increaseSpawn);
            Instantiate(enemy, new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(10.0f, 30.0f)), Quaternion.identity);
            Instantiate(enemy2, new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(20.0f, 50.0f)), Quaternion.identity);
            Instantiate(enemy3, new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(100.0f, 150.0f)), Quaternion.identity);
            yield return new WaitForSeconds(7.0f - increaseSpawn);
            Instantiate(enemy4, new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(100.0f, 150.0f)), Quaternion.identity);
            Instantiate(enemy4, new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(100.0f, 150.0f)), Quaternion.identity);
            Instantiate(enemy4, new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(100.0f, 150.0f)), Quaternion.identity);
            Instantiate(enemy4, new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(100.0f, 150.0f)), Quaternion.identity);
            Instantiate(enemy5, new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(100.0f, 150.0f)), Quaternion.identity);
            increaseSpawn = increaseSpawn + 0.50f;
            if(increaseSpawn == 6.5f)
            {
                increaseSpawn = 3.5f;
            }
        }
    }
}
