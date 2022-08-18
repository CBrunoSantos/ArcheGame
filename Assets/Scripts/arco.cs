using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arco : MonoBehaviour
{
    // Start is called before the first frame update

        public GameObject projetil;

    // public float velocidadeProjetil;

    //     private float tempoUltimoTiro;

    // private bool estaAtirando = false;

    public Transform spawnBullet;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Atirar();
        Mirar();
    }

    void Atirar(){
        if (Input.GetButtonDown("Fire1")){
            Transform shotPoint = spawnBullet;
            Instantiate(projetil, shotPoint.position, transform.rotation);
        }
    }

    void Mirar(){
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 offset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0, angle);
    }
}
