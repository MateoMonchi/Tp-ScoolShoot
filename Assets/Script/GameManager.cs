using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia { get; private set; }
    private float timer;
    private bool juegoEnProgreso;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(gameObject);
            juegoEnProgreso = true;
        }
        else
        {
            Debug.Log("¡Cuidado! Más de un GameManager en la escena.");
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (juegoEnProgreso)
        {
            timer += Time.deltaTime;
            if (timer >= 10f)
            {
                GanarJuego();
            }
        }
    }

    public void PerderJuego()
    {
        try
        {
            juegoEnProgreso = false;
            SceneManager.LoadScene("Derrota");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al cargar la escena Derrota: " + e.Message);
        }
    }

    public void GanarJuego()
    {
        try
        {
            juegoEnProgreso = false;
            SceneManager.LoadScene("ganar");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al cargar la escena ganar: " + e.Message);
        }
    }

    public void IrAlMenu(string Menu)
    {
        try
        {
            SceneManager.LoadScene(Menu);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al cargar la escena: " + Menu + e.Message);
        }
    }
}