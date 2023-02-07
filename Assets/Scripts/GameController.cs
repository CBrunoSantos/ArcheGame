using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{

    public CameraFollow cameraFollow;
    public Transform playerTransform;
    public GameObject gameOver;
    public static GameController instance;
    public int totalPoints;
    public int totalCoins;
    public Text pointText;
    public Text coinText;
    public Text text;
    public arco arco;

    private int Coin;

    public GameObject Shop;

    // Start is called before the first frame update
    void Start(){
        cameraFollow.Setup(() => playerTransform.position);
        instance = this;
        UpdateAmmoText();
    }
    

    private void Update(){
        UpdateAmmoText();
    }

    // Update is called once per frame
    public void ShowGameOver(){
        gameOver.SetActive(true);
        Time.timeScale=0;
        // Cursor.lockState = CursorLockMode.Locked;
    }

    public void ShowShop(){
        Shop.SetActive(true);
        // Cursor.lockState = CursorLockMode.Locked;
    }

        public void ShowOffShop(){
        Shop.SetActive(false);
        Time.timeScale=1;
    }

    public void Restart(string lvlName){
        SceneManager.LoadScene(lvlName);
        // Debug.Log("teste");
        // Time.timeScale=1;
    }

    public void UpdateAmmoText(){
        text.text = $"{arco.currentClip}/{arco.maxClipeSize}|{arco.currentAmmo}/{arco.maxAmmoSize}";
    }

    public void UpdatePointText(){
        pointText.text = totalPoints.ToString();
    }

    public void UpdateCoinText(){
        coinText.text = totalCoins.ToString();
    }

    public void UpdateVel(){
        Coin-=10;
        totalCoins-=10;
        if(totalCoins<=0){
            Debug.Log("cabou o dinheiro corno");
        }
        UpdateCoinText();
            Movement.instance.velPlayer+=1;
            Debug.Log("movimento"+Movement.instance.velPlayer);
    }

    public void UpdateDano(){
        Coin-=10;
        totalCoins-=10;
        if(totalCoins<=0){
            Debug.Log("cabou o dinheiro corno");
        }
        UpdateCoinText();
            Teste.instance.velTiro+=1;
            Debug.Log(Coin);
            // Debug.Log("tiro"+Teste.instance.velTiro);
    }
}
