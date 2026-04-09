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
        scene_Manager.ys += diry;
        tile_Manager.Begin();
        if(dirx == 0)
        {
            if (diry == 1) player.transform.position = new Vector3(6, 8.9f, 0);
            else { player.transform.position = new Vector3(11, 1.1f, 0); player.rb.AddForceY(6, ForceMode2D.Impulse); }
            } else{
            if (dirx == 1) player.transform.position = new Vector3(1, 5, 0);
            else player.transform.position = new Vector3(16, 5, 0);
        }
    }
}
