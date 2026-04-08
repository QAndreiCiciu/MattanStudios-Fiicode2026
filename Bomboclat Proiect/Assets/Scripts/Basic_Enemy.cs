using UnityEngine;

public class Basic_Enemy : MonoBehaviour
{
    public Player_Behaviour player;
    public BoxCollider2D boxCollider;
    public Rigidbody2D rb;
    public float jump, speed,cJ;

    void FixedUpdate()
    {
        if (player.transform.position.x < this.transform.position.x) this.transform.rotation = new Quaternion(0, 180, 0, 0);
        else this.transform.rotation = new Quaternion(0, 0, 0, 0);
        transform.Translate(new Vector3(speed,0,0)*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            rb.AddForceY(cJ, ForceMode2D.Impulse);
            cJ = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player") cJ = jump;
    }
}
