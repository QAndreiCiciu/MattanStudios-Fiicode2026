using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using Random = System.Random;


public class Tile_manager : MonoBehaviour
{
    private Tile _tempTile;
    public int sceneType;
    public SceneManager manager;
    public TextMeshProUGUI text;
    public Sprite bg;
    void Start()
    {
        Res();
        Begin();
    }
    public void Begin()
    {
        
        generate();
    }
    
    private void Res()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++) 
                manager.matFloor[i, j] = 0;
        }
        manager.xs = 0;
        manager.ys = 0;
    }

    private void generate()
    {
        text.text = "x: " + manager.xs + "\ny:" + manager.ys;
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
       if(manager.xs!=0)
        {
            _tempTile = GameObject.Find($"Tile 1 3").GetComponent<Tile>();
            _tempTile._sprite = bg;
            _tempTile._coll = false;

            _tempTile.Init();
        }
        if (manager.xs != 2)
        {
            _tempTile = GameObject.Find($"Tile 16 3").GetComponent<Tile>();
            _tempTile._sprite = bg;
            _tempTile._coll = false;

            _tempTile.Init();
        }
        if (manager.ys != 0)
        {
            _tempTile = GameObject.Find($"Tile 2 9").GetComponent<Tile>();
            _tempTile._sprite = bg;
            _tempTile._coll = false;

            _tempTile.Init();
        }
        if (manager.ys != 2)
        {
            _tempTile = GameObject.Find($"Tile 15 1").GetComponent<Tile>();
            _tempTile._sprite = bg;
            _tempTile._coll = false;

            _tempTile.Init();
        }
    }
}
