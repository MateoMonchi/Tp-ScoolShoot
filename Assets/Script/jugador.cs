using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public float speed = 3f;
    public float rotSpeed = 200f;

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
        transform.position = pos;
      
    }
    
}

