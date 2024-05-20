using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorJugador : MonoBehaviour
{
    public Vector3 laserOffset = new Vector3(0, 0.5f, 0);
    public GameObject laserPrefab;
    public float fireDelay = 0.25f;
    float coolDownTimer = 0;
    void Update()
    {
        coolDownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && coolDownTimer <= 0)
        {
            Debug.Log("Pew!");
            coolDownTimer = fireDelay;
            Vector3 offset = transform.rotation * laserOffset;
            Instantiate(laserPrefab, transform.position, transform.rotation);
        }
    }
}
