using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetils : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempoDeVida;
    public float distancia;
    public Rigidbody2D rb_arrow;
    public float speed;
    void Start()
    {
        Invoke("DestruirProjetil", tempoDeVida);
    }

    // Update is called once per frame
    void Update(){
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

        void DestruirProjetil(){
        Destroy(gameObject);
    }

            void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            Debug.Log("ai iaiaiaiai");
            Destroy(gameObject);
        }
    }
}
