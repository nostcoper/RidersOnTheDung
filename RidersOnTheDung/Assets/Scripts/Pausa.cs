using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;

public class Pausa : MonoBehaviour
{

    public AudioSource clip;
    [SerializeField] private GameObject ButtonPausa;
    [SerializeField] private GameObject menuPausa;

    private bool juegoPausado = false;
        private void update(){
        if(!juegoPausado && Input.GetKeyDown(KeyCode.Pause)){
            if(juegoPausado){
                Reanudar();
            }else{
                Pausar();
            }
        }
    }
    public void Pausar(){
        juegoPausado = true;
        clip.Pause();
        Time.timeScale = 0f;
        ButtonPausa.SetActive(false);
        menuPausa.SetActive(true);
        //DontDestroyOnLoad(gameObject);
        
    }

    public void Reanudar(){
        juegoPausado = false;
        clip.Play();
        Time.timeScale = 1f;
        ButtonPausa.SetActive(true);
        menuPausa.SetActive(false);
        //DontDestroyOnLoad(gameObject);

    }

    public void Reiniciar(){
        juegoPausado = false;
        clip.Play();
        Time.timeScale = 1f;
        ButtonPausa.SetActive(true);
        menuPausa.SetActive(false);
        SceneManager.LoadScene("Nivel");
        StartCoroutine(DestroyAfterLoad());
    }

    private IEnumerator DestroyAfterLoad() {
        yield return null; // Esperar hasta el siguiente frame para asegurarse de que la escena se ha cargado
        Destroy(gameObject);
    }


    public void Salir(){
        juegoPausado = false;
        Time.timeScale = 1f;
        ButtonPausa.SetActive(false);
        menuPausa.SetActive(false);
        
        
        // Descarga la escena del juego actual
        //SceneManager.UnloadSceneAsync("Nivel");
        SceneManager.LoadScene("MenuPrincipal");
    }
    /*
    public void PauseSoundFondo(){
        clip.mute = !clip.mute;
    }

    public void PlaySoundFondo(){
        clip.Play();
    }

    public void PlaySoundBtn(AudioClip audio){
        clip.PlayOneShot(audio);
    }
    */
}
