using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject gameOver;
    public static GameController instance;
    public int totalPoints;
    public Text pointText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    public void ShowGameOver(){
        gameOver.SetActive(true);
    }

    public void Restart(string lvlName){
        SceneManager.LoadScene(lvlName);
        // Debug.Log("teste");
    }

    public void UpdatePointText(){
        pointText.text = totalPoints.ToString();
    }
}
