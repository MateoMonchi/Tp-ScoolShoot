using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour
{
    public float rotSpeed = 90;
    Transform Jugador;
 
    void Update()
    {
        if(Jugador == null)
        {
            GameObject go = GameObject.FindWithTag("Player");
            if(go != null)
            {
                Jugador = go.transform;
            }
        }
        if(Jugador == null)
        {
            return;
        }
        Vector3 dir = Jugador.position - transform.position;
        dir.Normalize();
        float anguloZ = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg - 90;
        Quaternion desireShoot = Quaternion.Euler(0,0 ,anguloZ);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desireShoot, rotSpeed * Time.deltaTime);
        
    }
}
