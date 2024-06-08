using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInicial : MonoBehaviour
{

    public void Jugar(){
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Nivel");
    }

    public void Instrucciones(){
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Instrucciones");
    }

    public void Creditos(){
        //SceneManager.UnloadSceneAsync("menuInicial");
        SceneManager.LoadScene("Creditos");
    }

    public void Salir(){
        Application.Quit();
    }

    
}
