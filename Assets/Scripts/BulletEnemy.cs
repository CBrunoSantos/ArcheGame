using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    GameObject target;
    public Rigidbody2D rb_arrow;
    public float speed;
    void Start()
    {
        rb_arrow = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        rb_arrow.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
    }

                void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            Debug.Log("ai iaiaiaiai");
            Destroy(gameObject);
        }
    }
}
