using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDisparador : MonoBehaviour
{
    public Vector3 laserOffset = new Vector3(0, 0.5f, 0);
    public GameObject laserPrefab;
    Transform Jugador;
    int laserLayer;
    public float fireDelay = 0.50f;
    float coolDownTimer = 0;
    void Start()
    {
        laserLayer = gameObject.layer;
    }
    void Update()
    {
        coolDownTimer -= Time.deltaTime;
        if (coolDownTimer <= 0 && Jugador != null && Vector3.Distance(transform.position, Jugador.position) < 3)
        {
            Debug.Log("Enemigo Pew!");
            coolDownTimer = fireDelay;
            Vector3 offset = transform.rotation * laserOffset;
            GameObject laserGo = (GameObject) Instantiate(laserPrefab, transform.position, transform.rotation);
            laserGo.layer = gameObject.layer;
        }
    }
}
