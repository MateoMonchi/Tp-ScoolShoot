using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform Jugador;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - Jugador.position;
    }


    void Update()
    {
        Vector3 targetPos = Jugador.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}

