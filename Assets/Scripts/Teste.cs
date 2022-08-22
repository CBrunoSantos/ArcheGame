using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public float tempoDeVida;
    public float distancia;
    public Rigidbody2D rbAlvo;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruirProjetil", tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 10);
    }

    void DestruirProjetil(){
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "wall"){
            Debug.Log("parede");
            Destroy(gameObject);
        }else if(collision.gameObject.tag == "Inimigo"){
            Debug.Log("tocou no inimigo");
            Destroy(gameObject);
        }
    }
}
