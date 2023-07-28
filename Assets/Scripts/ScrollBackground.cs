using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float speed; // Velocidad de movimiento del fondo
    
    [SerializeField]
    private Renderer bgRenderer;

    void Update()
    {
        // Mueve el fondo en la dirección negativa del eje X (izquierda) con la velocidad especificada.
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }

}