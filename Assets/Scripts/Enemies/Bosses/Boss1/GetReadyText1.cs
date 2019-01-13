using UnityEngine;

public class GetReadyText1 : MonoBehaviour
{
    public GameObject GetReadyText;

    void Start()
    {
        Instantiate(GetReadyText, new Vector2(0, 1.46f), transform.rotation);
    }
}
