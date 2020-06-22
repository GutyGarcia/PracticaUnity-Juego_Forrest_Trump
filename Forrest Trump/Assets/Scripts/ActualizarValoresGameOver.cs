using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarValoresGameOver : MonoBehaviour
{
    public TextMesh total;
    public TextMesh record;
    public Puntuacion puntuacion;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnEnable()
    {
        total.text = puntuacion.puntuacion.ToString();
        if(EstadoJuego.estadoJuego != null)
        {
            record.text = EstadoJuego.estadoJuego.puntuacionMaxima.ToString();
        }
        
    }
}
