using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public int puntuacion = 0;
    public TextMesh marcador;
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeMuerto");
        actualizarMarcador();
    }

    void PersonajeMuerto(Notification notificacion)
    {
        if(puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima)
        {
            EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
            EstadoJuego.estadoJuego.Guardar();
        }
    }
    void IncrementarPuntos(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacion += puntosAIncrementar;
        actualizarMarcador();
    }

    void actualizarMarcador()
    {
        marcador.text = puntuacion.ToString();
    }
    void Update()
    {
        
    }
}
