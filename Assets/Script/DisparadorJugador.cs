using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorJugador : MonoBehaviour
{
    public GameObject laserBluePrefab;
    public float fireDelay = 0.25f;
    float coolDownTimer = 0;
    void Update()
    {
        coolDownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && coolDownTimer <= 0)
        {
            Debug.Log("Pew!");
            coolDownTimer = fireDelay;
            Instantiate(laserBluePrefab, transform.position, transform.rotation);
        }
    }
}
