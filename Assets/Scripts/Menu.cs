using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string cena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jogar(){
        SceneManager.LoadScene("lvlCinco");
    }
    public void comoJogar(){
        SceneManager.LoadScene("ComoJogar");
    }
    public void Creditos(){
        // UnityEditor.EditorApplication.isPlaying = false;
        SceneManager.LoadScene("Creditos");
    }
}
