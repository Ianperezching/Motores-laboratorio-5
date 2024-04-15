using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    public float puntos;
    public TextMeshProUGUI TextMesh;
    private void Start()
    {
        TextMesh = GetComponent<TextMeshProUGUI>();
        Movimientojugador.cambiarpuntos += cambiodepuntos;
    }
    private void Update()
    {
        TextMesh.text = "Puntos: "+ puntos.ToString();
    }
    public void Sumarpuntos(int puntosmonedas)
    {
        puntos += puntosmonedas;
    }
    public void cambiodepuntos()
    {
        puntos = puntos+10;
    }
}
