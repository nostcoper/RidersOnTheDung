using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class timerScript : MonoBehaviour
{
    public TextMeshProUGUI textTimer;
    public float time;

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;

        }
        else if (time < 0)
        {
            time = 0;
            textTimer.text = "Time is Over";
            textTimer.color = Color.red;
            SceneManager.LoadScene("MenuPrincipal");
        }


        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
