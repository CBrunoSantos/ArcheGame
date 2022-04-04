using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    private float tempoUltimoTiro;

    private bool estaAtirando = false;
    public Transform croos;

    public GameObject projetil;

    public float velocidadeProjetil;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Atirar();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0.0f);
        transform.position = transform.position + movement * Time.deltaTime * 5;
    }

        void Atirar(){
        if (Input.GetMouseButtonDown(0)){
            Transform shotPoint = croos;
            
            GameObject projetils = Instantiate(projetil, shotPoint.position, transform.rotation);

            estaAtirando = true;
            tempoUltimoTiro = .7f;


        if(Input.GetAxis("Horizontal") > 0f || Input.GetAxis("Horizontal") == 0f){
            projetils.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeProjetil, 0);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else if(Input.GetAxis("Horizontal") < 0f || Input.GetAxis("Horizontal") == 0f){
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            projetils.GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadeProjetil, 0);
        }
        
        }


        tempoUltimoTiro -= Time.deltaTime;
        if(tempoUltimoTiro <= 0 ){
            estaAtirando = true;
        }
    }
}
