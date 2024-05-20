using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public float speed = 3f;
    public float rotSpeed = 180f;
    float radioLimite = 0.5f;

    void Start()
    {
   
    }


    void Update()
    {
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0,0,z);
        transform.rotation = rot;
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        pos += rot * velocity;
        if(pos.y+radioLimite > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - radioLimite;
        }
        if (pos.y - radioLimite < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + radioLimite;
        }
        float screenRadio = (float)Screen.width / (float)Screen.height;
        float Ancho = Camera.main.orthographicSize * screenRadio;
        if (pos.x + radioLimite > Ancho)
        {
            pos.x = Ancho - radioLimite;
        }
        if (pos.x - radioLimite < -Ancho)
        {
            pos.x = -Ancho + radioLimite;
        }
        transform.position = pos;
    }
    
}

