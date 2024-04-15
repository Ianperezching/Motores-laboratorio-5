using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;


public class cambiardecolor : MonoBehaviour
{
    public GameObject pausa;
    public GameObject menudepausa;
    public TextMeshProUGUI tiempo;
    public float Tiempoenelnivel;
    
    public void Update()
    {
        contador();
    }
    public void Start()
    {
        Movimientojugador.Perder += Perder;
        Movimientojugador.Ganar += Ganar;
    }
    public void OnDestroy()
    {
        Movimientojugador.Perder -= Perder;
        Movimientojugador.Ganar -= Ganar;
    }
    public void contador()
    {
        Tiempoenelnivel = Tiempoenelnivel + Time.deltaTime;
        tiempo.text= "Tiempo:" + (Tiempoenelnivel).ToString("F0");
    }
    public void pausar()
    {
        menudepausa.SetActive(true);
        Time.timeScale = 0;
    }
    public void despausar()
    {
        menudepausa.SetActive(false);
        Time.timeScale = 1;
    }
    public void Perder()
    {
        SceneManager.LoadScene("Derrota");
    }
    public void Ganar()
    {
        SceneManager.LoadScene("Victoria");
    }
    
   
}
