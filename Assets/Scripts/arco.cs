using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arco : MonoBehaviour
{

    public static arco instance;
    public GameObject projetil;
    // public float velocidadeProjetil;
    // private float tempoUltimoTiro;
    // private bool estaAtirando = false;
    public Transform spawnBullet;
    public int ammoAmount;

    public int currentClip = 10, maxClipeSize = 10, currentAmmo, maxAmmoSize = 50;
    void Start(){
        instance = this;
        // Debug.Log(maxAmmoSize);
    }
    void Update()
    {

        Atirar();
        Mirar();
    }

    void Atirar(){
        if (Input.GetButtonDown("Fire1")){
            if(currentClip> 0){
                Transform shotPoint = spawnBullet;
                Instantiate(projetil, shotPoint.position, transform.rotation);
                currentClip--;
            }
        }

        if(Input.GetKeyDown(KeyCode.R)){
            Reload();
        }
    }

    public void Reload(){
        int reloadAmount = maxClipeSize - currentClip;
        reloadAmount = (currentAmmo - reloadAmount)>= 0 ? reloadAmount : currentAmmo;
        currentClip += reloadAmount;
        currentAmmo -= reloadAmount;
    }

    public void AddAmmo(){
        currentAmmo += ammoAmount;
        Debug.Log(currentAmmo);
        if(currentAmmo > maxAmmoSize){
            currentAmmo = maxAmmoSize;
            
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
