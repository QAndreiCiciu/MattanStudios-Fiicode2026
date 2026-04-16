using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class Tile_Mattia : MonoBehaviour
{
    private Tile _tempTile;
    public int sceneType;
    void Start()
    {
        generate();
    }

    private void generate()
    {
        var _scene = Resources.Load<SceneTemplate>($"Scene {sceneType}");
        List<ListElem> x = _scene.elems;
        for (int i = 0; i < x.Count; i++)
        {
            for (int j = x[i].x1; j <= x[i].x2; j++)
            {
                for (int k = x[i].y1; k <= x[i].y2; k++)
                {
                    _tempTile = GameObject.Find($"Tile {j} {k}").GetComponent<Tile>();
                    _tempTile._sprite = x[i].blockSprite;
                    _tempTile._coll = x[i].collide;

                    _tempTile.Init();
                }
            }
        }
    }
}
