using TMPro;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public Tile_manager tile_Manager;
    public SceneManager scene_Manager;
    public Player_Behaviour player;
    public int dirx, diry;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        scene_Manager.xs += dirx;
        scene_Manager.ys += diry;tile_Manager.Begin();
        player.transform.position = new Vector3(2, 2, 0);
    }
}
