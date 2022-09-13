using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private HealthBar healthBar;

    public float velPlayer;
    public Rigidbody2D rb;
    float health = 1f;
    private float toque = .01f;

    private void Start(){}

    void Update(){

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0.0f);
        rb.velocity = new Vector2(movement.x * velPlayer , movement.y * velPlayer);
        if(Input.GetAxis("Horizontal")>0f){
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        if(Input.GetAxis("Horizontal")<0f){
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
            if(collision.gameObject.tag == "Inimigo"){
                Invoke("DanoBasico", toque);
            } else if(collision.gameObject.tag == "Life"){
                Invoke("vida", toque);
            }
        }

    void vida(){
        if(health != health){
            health += .50f;
        }
        // health++;
        healthBar.SetSize(health); 
    }

    void DanoBasico(){
            // Debug.Log("tocou no player");
            health -= .5f;
            healthBar.SetSize(health); 
                if(health<=0){
                    GameController.instance.ShowGameOver();
                    Destroy(gameObject, 0f);
                }
            }


}
