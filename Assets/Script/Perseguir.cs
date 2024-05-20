using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour
{
    public Transform Jugador;
 
    void Update()
    {
        if(Jugador == null)
        {
            GameObject go = GameObject.Find("Player");
            if(Jugador != null)
            {
                Jugador = go.transform;
            }
        }
        if(Jugador == null)
        {
            return;
        }
        Vector3 dir = Jugador.position - transform.position;
        Quaternion.LookRotation(dir);
    }
}
