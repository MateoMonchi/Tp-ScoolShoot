using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScollUv : MonoBehaviour
{
   
    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.x += Time.deltaTime / 10f;
        mat.mainTextureOffset = offset;
    }
}
