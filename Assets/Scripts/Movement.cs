using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update


    public float velPlayer;
    public Rigidbody2D rb;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0.0f);
        // transform.position = transform.position + movement * Time.deltaTime * velPlayer;
        rb.velocity = new Vector2(movement.x * velPlayer , movement.y * velPlayer);
        if(Input.GetAxis("Horizontal")>0f){
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }

        if(Input.GetAxis("Horizontal")<0f){
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
    }

}
