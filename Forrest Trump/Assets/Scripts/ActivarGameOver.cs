using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarGameOver : MonoBehaviour
{
    public GameObject camaraGameOver;
    public AudioClip gameOverClip;
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeMuerto");
    }

    void PersonajeMuerto(Notification notificacion)
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().clip = gameOverClip;
        GetComponent<AudioSource>().loop = false;
        GetComponent<AudioSource>().Play();
       camaraGameOver.SetActive(true);
    }
    void Update()
    {
        
    }
}
