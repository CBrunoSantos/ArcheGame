using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetils : MonoBehaviour
{
    // Start is called before the first frame update
    public int dano;
    public float tempoDeVida;
    public float distancia;

    public float speed;
    void Start()
    {
        Invoke("DestruirProjetil", tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
                // RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.forward, distancia);

                transform.Translate(Vector3.right * Time.deltaTime * speed);

        // if(hitInfo.collider != null){
        //     if(hitInfo.collider.CompareTag("Inimigo")){
        //         hitInfo.collider.GetComponent<EnemyFollow>().TakeDamage(dano);
        //     } else if (hitInfo.collider.CompareTag("InimigoPatrulha")){
        //         hitInfo.collider.GetComponent<SystemRonda>().TakeDamage(dano);
        //     } else if (hitInfo.collider.CompareTag("InimigoWall")){
        //         hitInfo.collider.GetComponent<Enemyshot>().TakeDamage(dano);
        //     }
        //     DestruirProjetil();
        // }
    }

        void DestruirProjetil(){
        Destroy(gameObject);
    }
}
