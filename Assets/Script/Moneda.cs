using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int cantidaddepuntos;
    public Puntos puntaje;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            puntaje.Sumarpuntos(cantidaddepuntos);
            Destroy(gameObject);
           
        }
        
    }
}
