using UnityEngine;

public class Tile : MonoBehaviour
{
    public SpriteRenderer _renderer;
    public BoxCollider2D _circleCollider;
    public int _posX, _posY;
    public bool _coll;
    public Sprite _sprite;

    public void Init()
    {
        _renderer.sprite = _sprite;
        _circleCollider.enabled = _coll;
    }

}
