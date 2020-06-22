using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : MonoBehaviour
{
    public int puntosGanados = 10;
    public AudioClip sonidoFruta;
    public float volumenSonidoFruta = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
           NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
           AudioSource.PlayClipAtPoint(sonidoFruta, Camera.main.transform.position, volumenSonidoFruta);
        }
        Destroy(gameObject);
    }
}
