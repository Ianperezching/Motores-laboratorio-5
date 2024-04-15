using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambiarescena : MonoBehaviour
{
  
    public void pasar()
    {
        SceneManager.LoadScene("nivel 1");
    }
    public void salir()
    {
        Debug.Log("Salir");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
   
}
