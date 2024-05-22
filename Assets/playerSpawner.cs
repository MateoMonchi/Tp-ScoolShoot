using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    GameObject playerInstance;
    float respawnTimer;
    public int numVidas = 4;
    void Start()
    {
        spawnPlayer();
    }

    void spawnPlayer()
    {
        numVidas--;
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
    void Update()
    {
        if(playerInstance == null && numVidas > 0)
        {
            respawnTimer -= Time.deltaTime;
            if(respawnTimer <= 0)
            {
                spawnPlayer();
            }
        }
    }
    void OnGUI()
    {
        if (numVidas > 0 || playerInstance != null)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Vidas: " + numVidas);
        }
        else
        {
            GUI.Label(new Rect(Screen.width/ 2 - 50,Screen.height/ 2- 25, 100, 50),"Game Over" );
        }

    }
}
