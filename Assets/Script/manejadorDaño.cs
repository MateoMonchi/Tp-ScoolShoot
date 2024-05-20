using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manejadorDaño : MonoBehaviour
{
    public int salud = 1;
    float TiempoInvuln = 0;
    int correctLayer;
    public float invulnPeriodo = 0;
    void Start()
    {
        correctLayer = gameObject.layer;  
    }
    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");
        
       salud--;
       TiempoInvuln = invulnPeriodo;
       gameObject.layer = 8;
        
    }
    void Update()
    {
        TiempoInvuln -= Time.deltaTime;
        if(TiempoInvuln <= 0)
        {
           gameObject.layer = correctLayer;
        }

        if (salud <= 0)
        {
            Muerte();
        }
    }
    void Muerte()
    {
        Destroy(gameObject);
    }
}
