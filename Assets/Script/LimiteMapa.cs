using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMapa : MonoBehaviour
{
   
    private Camera _camaraPrincipal;
    private Vector2 _limitesMinimos;
    private Vector2 _limitesMaximos;
    private float _mitadAncho;
    private float _mitadAltura;

    void Start()
    {
        _camaraPrincipal = Camera.main;
        ActualizarLimitesCamara();
    }

    void Update()
    {
        ActualizarLimitesCamara();
        RestringirPosicion();
    }

    void ActualizarLimitesCamara()
    {
        // Calcula los l�mites de la c�mara
        _mitadAltura = _camaraPrincipal.orthographicSize;
        _mitadAncho = _camaraPrincipal.aspect * _mitadAltura;

        _limitesMinimos = (Vector2)_camaraPrincipal.transform.position - new Vector2(_mitadAncho, _mitadAltura);
        _limitesMaximos = (Vector2)_camaraPrincipal.transform.position + new Vector2(_mitadAncho, _mitadAltura);
    }

    void RestringirPosicion()
    {
        // Obtiene y restringe la posici�n del objeto dentro de los l�mites de la c�mara
        Vector3 posicion = transform.position;
        posicion.x = Mathf.Clamp(posicion.x, _limitesMinimos.x, _limitesMaximos.x);
        posicion.y = Mathf.Clamp(posicion.y, _limitesMinimos.y, _limitesMaximos.y);

        // Actualiza la posici�n del objeto
        transform.position = posicion;
    }
}

