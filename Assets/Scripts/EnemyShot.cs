using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public float shootingRange;
    [SerializeField] private HealthBar healthBar;
    public GameObject projetil;
    public GameObject projetilParent;
    // public Enemy enemy;
    private int speed = 5;
    private Transform player;
        float health = 1f;
    private int Points;
    private int Coin;
    public float fireRate = 1f;
    private float nextFireTime;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        if(distanceFromPlayer > shootingRange){
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        } else if(distanceFromPlayer <= shootingRange && nextFireTime < Time.time){
            Instantiate(projetil, projetilParent.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }

    }

    private void OnDrawGizmosSelected(){
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, shootingRange);
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
                    Coin = GameController.instance.totalCoins+=10;
                    GameController.instance.UpdatePointText();
                    GameController.instance.UpdateCoinText();
                    Debug.Log(Points);
                    Destroy(gameObject, 0f);
                }
            }
}
