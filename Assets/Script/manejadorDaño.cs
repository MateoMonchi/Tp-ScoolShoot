using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manejadorDaño : MonoBehaviour
{
    int salud = 1;
    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");
        salud--;
        if(salud <= 0)
        {
            Muerte();
        }
    }
    void Muerte()
    {
        Destroy(gameObject);
    }
}
