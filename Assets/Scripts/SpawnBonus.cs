using UnityEngine;

public class SpawnBonus : MonoBehaviour {

    public GameObject newWeapon2;
    public GameObject immortality;

    private int rand;

    void Start () {
        rand = Random.Range(1, 10);
        if (rand == 5)
        {
            Instantiate(newWeapon2, new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(60f, 100f)), Quaternion.identity);
        }
        if (rand == 6)
        {
            Instantiate(immortality, new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(60f, 100f)), Quaternion.identity);
        }
    }
}
