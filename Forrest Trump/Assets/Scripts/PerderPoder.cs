using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerderPoder : MonoBehaviour
{
    public AudioClip sonidoPerderPoder;
    public float volumenSonidoPerderPoder = 1f;
   
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
            NotificationCenter.DefaultCenter().PostNotification(this, "QuitarPoderes");
            AudioSource.PlayClipAtPoint(sonidoPerderPoder, Camera.main.transform.position, volumenSonidoPerderPoder);

        }
        Destroy(gameObject);
    }
}
