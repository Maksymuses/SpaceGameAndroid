using UnityEngine;

public class NewWeaponPick1 : MonoBehaviour {

    public int type;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Pplayer>().ChangeWeapon(type);
            Destroy(gameObject);
        }
    }
}
