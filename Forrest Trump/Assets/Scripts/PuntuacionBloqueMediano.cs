using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionBloqueMediano : MonoBehaviour
{
    private bool colisionConElJugador = false;
    public int puntosGanados = 3;
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!colisionConElJugador && collision.gameObject.tag == "Player")
        {
            GameObject obj = collision.contacts[0].collider.gameObject;
            if (obj.name == "PieDerecho" || obj.name == "PieIzqdo")
            {
                colisionConElJugador = true;
                NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
            }
        }
    }
}
