using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public bool IniciarEnMovimiento = false;
    public float velocidad = 0f;
    private bool enMovimiento = false;
    private float tiempoInicio = 0f;
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeMuerto");
        if (IniciarEnMovimiento)
        {
            PersonajeEmpiezaACorrer();
        }
        
    }
    void PersonajeMuerto()
    {
        enMovimiento = false;
    }

    void PersonajeEmpiezaACorrer() 
    {
        enMovimiento = true;
        tiempoInicio = Time.time;
    }

    void Update()
    {
        if (enMovimiento)
        {
           GetComponent<Renderer>().material.mainTextureOffset = new Vector2(((Time.time - tiempoInicio) * velocidad) % 1, 0);
        }
        
    }
}
