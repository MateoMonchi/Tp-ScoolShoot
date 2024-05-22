using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manejadorDaño : MonoBehaviour
{
    public int salud = 1;
    float TiempoInvuln = 0;
    int correctLayer;
    public float invulnPeriodo = 0;
    SpriteRenderer spriteRender;
    float invulnAnimTimer = 0;
    void Start()
    {
        correctLayer = gameObject.layer;  
        spriteRender = GetComponent<SpriteRenderer>();
        if (spriteRender == null)
        {
            spriteRender = transform.GetComponentInChildren<SpriteRenderer>();
        }
        if(spriteRender == null)
        {
            Debug.LogError("Objeto'"+gameObject.name+"'no hay sprite render");
        }
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
            if(spriteRender != null)
            {
                spriteRender.enabled = true;
            }
        }
        else
        {
            if (spriteRender != null)
            {
                spriteRender.enabled = !spriteRender.enabled;
            }
        }

        if (salud <= 0)
        {
            Muerte();
        }
    }
    void Muerte()
    {
        GameManager.Instancia.PerderJuego();
        Destroy(gameObject);
    }
}
