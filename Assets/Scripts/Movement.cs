using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private HealthBar healthBar;

    public float velPlayer;
    public Rigidbody2D rb;
    public float health = 1f;
    private float toque = .01f;
    // public float valor = 0;
    public static Movement instance;
    

    void Start(){
        instance = this;
    }

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
            } 
            // else if(collision.gameObject.tag == "Life"){
            //     Invoke("vida", toque);
            // }
        }

    //tirar tudo que n for movimentação daqui e fazer itens consumiveis em outro script
    public void vida(){
        float vida = 1f;
        if(vida != vida){
            vida += .50f;
        }
        // health++;
        // Debug.Log("eu vou surtar se n der certo");
        healthBar.SetSize(vida); 
    }

    void DanoBasico(){
            // Debug.Log("tocou no player");
            health -= .05f;
            healthBar.SetSize(health); 
                if(health<=0){
                    GameController.instance.ShowGameOver();
                    Destroy(gameObject, 0f);
                }
            }


}
