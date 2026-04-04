using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneTemplate", menuName = "SceneType")]
public class SceneTemplate : ScriptableObject
{
    public List<ListElem> elems;
}
