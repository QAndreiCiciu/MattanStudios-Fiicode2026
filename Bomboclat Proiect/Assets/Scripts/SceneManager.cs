using System.Runtime.Serialization;
using UnityEngine;
using Random = System.Random;

[CreateAssetMenu(fileName = "SceneManager", menuName = "SceneManager")]
public class SceneManager : ScriptableObject
{
    public int xs=0, ys=0, type;
    public int[,] matFloor = new int[3,3];
    public void change()
    {

    }
}
