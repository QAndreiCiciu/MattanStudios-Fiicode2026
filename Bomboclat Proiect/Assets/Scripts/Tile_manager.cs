using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using Random = System.Random;


public class Tile_manager : MonoBehaviour
{
    private Tile _tempTile;
    public int sceneType;
    public SceneManager manager;
    void Start()
    {
        Begin();
    }
    public void Begin()
    {
        Res();
        generate();
    }
    
    private void Res()
    {
        manager.matFloor[manager.xs, manager.ys] = 0;
    }

    private void generate()
    {
        Random rnd = new Random();
        sceneType = rnd.Next(1,3);
        if (manager.matFloor[manager.xs, manager.ys] == 0)
        {
            manager.matFloor[manager.xs, manager.ys] = sceneType;
        }
        else sceneType = manager.matFloor[manager.xs, manager.ys];
        Debug.Log(manager.matFloor[manager.xs, manager.ys]);
        var _scene = Resources.Load<SceneTemplate>($"Scene {sceneType}");
        List<ListElem> x = _scene.elems;
        for(int i = 0;i<x.Count;i++) {
            for(int j = x[i].x1; j <= x[i].x2; j++)
            {
                for(int k = x[i].y1; k <= x[i].y2; k++)
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
