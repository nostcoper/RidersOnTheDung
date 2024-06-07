using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Instrucciones : MonoBehaviour
{
    public AudioSource clip;
    public void Atras(){
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Siguiente(){
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Creditos");
    }

    public void PlaySoundBtn(AudioClip audio){
        clip.PlayOneShot(audio);
    }
}
