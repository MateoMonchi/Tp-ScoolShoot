using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoInvolarse : MonoBehaviour
{
    public float timer = 1;
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
