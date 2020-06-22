using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    public int puntosGanados = -20;
    public AudioClip sonidoVeneno;
    public float volumenSonidoVeneno = 1f;
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
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
            AudioSource.PlayClipAtPoint(sonidoVeneno, Camera.main.transform.position, volumenSonidoVeneno);
        }
        Destroy(gameObject);
    }
}
