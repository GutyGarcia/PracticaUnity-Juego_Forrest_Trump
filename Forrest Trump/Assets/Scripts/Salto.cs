using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public AudioClip sonidoSalto;
    public float volumenSonidoSalto = 1f;
    private float saltoNuevo = 1f;
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
            NotificationCenter.DefaultCenter().PostNotification(this, "AumentarSalto", saltoNuevo);
            AudioSource.PlayClipAtPoint(sonidoSalto, Camera.main.transform.position, volumenSonidoSalto);

        }
        Destroy(gameObject);
    }
}

