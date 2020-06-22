using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCargarEscena : MonoBehaviour
{
    public string nombreEscenaParaCargar = "SampleScene";
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();
        Invoke("CargarNivelJuego", GetComponent<AudioSource>().clip.length);
    }

    void CargarNivelJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nombreEscenaParaCargar);
    }
}
