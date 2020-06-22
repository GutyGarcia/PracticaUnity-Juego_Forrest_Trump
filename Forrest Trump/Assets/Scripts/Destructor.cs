using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeMuerto");
            GameObject personaje = GameObject.Find("Personaje");
            if(personaje != null)
            {
            personaje.SetActive(false);
            }
        }
        else
        {
            Destroy(other.gameObject);
        }
        
    }
}
