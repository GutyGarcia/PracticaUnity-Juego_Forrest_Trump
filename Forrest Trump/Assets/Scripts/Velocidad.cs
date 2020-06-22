using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidad : MonoBehaviour
{
    public AudioClip sonidoVelocidad;
    public float volumenSonidoVelocidad = 1f;
    private float velocidadNueva = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "AumentarVelocidad", velocidadNueva);
            AudioSource.PlayClipAtPoint(sonidoVelocidad, Camera.main.transform.position, volumenSonidoVelocidad);

        }
        Destroy(gameObject);
    }
   
}
