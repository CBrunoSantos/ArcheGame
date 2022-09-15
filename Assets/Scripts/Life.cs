using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            Movement.instance.vida();
            Destroy(gameObject, 0f);
        }
}
}
