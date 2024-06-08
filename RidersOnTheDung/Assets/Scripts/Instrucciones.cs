using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Instrucciones : MonoBehaviour
{

    public void Atras(){
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Siguiente(){
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Creditos");
    }

    
}
