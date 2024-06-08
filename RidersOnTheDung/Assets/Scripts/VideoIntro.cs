using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoIntro : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        // Obtener el componente VideoPlayer
        videoPlayer = GetComponent<VideoPlayer>();

        // Agregar listener para el evento de finalización del video
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Cargar la escena del menú principal
        SceneManager.LoadScene("MenuPrincipal");
    }
}
