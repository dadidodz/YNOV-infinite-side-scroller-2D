using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject player;
    private PlayerMovements playerScript;
    public float currentTime;

    void Start()
    {
        playerScript = player.GetComponent<PlayerMovements>();
    }

    void Update()
    {
        if (!playerScript.isAlive){
            if (currentTime < 2){
                currentTime += Time.deltaTime;
                Debug.Log(currentTime);
            } else {
                GameOver();
            }
        }
    }

    public void GameOver(){
            GameOverUI.SetActive(true);
    }
}
