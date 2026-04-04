using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public Tile_manager manager;
    public Player_Behaviour player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.Begin();
        player.transform.position = new Vector3(2, 2, 0);
    }
}
