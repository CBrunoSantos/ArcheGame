using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    public Rigidbody2D rbEnemy;
    public float velEnemy;
    private Transform m_player;
    float health = 1f;
    private int Points;

    void Start(){
        m_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update(){
        float _distancia = Vector2.Distance(transform.position,m_player.position);
        transform.position = Vector2.MoveTowards(transform.position,m_player.position,velEnemy * Time.deltaTime);
    }
        void OnCollisionEnter2D(Collision2D collision){
            if(collision.gameObject.tag == "Player"){
                Destroy(gameObject, 0f);
            }else if(collision.gameObject.tag == "alvo"){
            Invoke("DanoTiro", 0f);
        }
    }
    void DanoTiro(){
            health -= .5f;
            healthBar.SetSize(health); 
                if(health<=0){
                    Points = GameController.instance.totalPoints++;
                    GameController.instance.UpdatePointText();
                    Debug.Log(Points);
                    Destroy(gameObject, 0f);
                }
            }

}
