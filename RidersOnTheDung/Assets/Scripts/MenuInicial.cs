using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInicial : MonoBehaviour
{

    public void Volver(){
        SceneManager.LoadScene("Nivel");
    }

    public void Instrucciones(){
        SceneManager.LoadScene("Instrucciones");
    }

    public void Creditos(){
        SceneManager.LoadScene("Creditos");
    }

    public void Salir(){
        Application.Quit();
    }

    public void Jugar(){
        SceneManager.LoadScene("INTRO");
    }

    
}
