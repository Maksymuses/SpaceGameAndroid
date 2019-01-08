using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Transform Player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag()
    {
        if (!Pplayer.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            Player.position = Vector2.MoveTowards(Player.position,
                new Vector2(mousePos.x, Player.position.y),
                speed * Time.deltaTime);
        }
    }

}
