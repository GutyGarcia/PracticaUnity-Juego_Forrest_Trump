using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public float fuerzaSalto = 8f;
    private bool enSuelo = true;
    public Transform comprobadorSuelo;
    private float comprobadorRadio = 0.07f;
    public LayerMask mascaraSuelo;

    private bool dobleSalto = false;

    private Animator animator;

    private bool corriendo = false;
    public  float velocidad = 8f;
    

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "AumentarVelocidad");
        NotificationCenter.DefaultCenter().AddObserver(this, "AumentarSalto");
        NotificationCenter.DefaultCenter().AddObserver(this, "QuitarPoderes");
    }
  
    void AumentarVelocidad(Notification notificacion)
    {
        float velocidadAIncrementar = (float)notificacion.data;
        velocidad = velocidad + velocidadAIncrementar;
    }
    void AumentarSalto(Notification notificacion)
    {
        float saltoAIncrementar = (float)notificacion.data;
        fuerzaSalto = fuerzaSalto + saltoAIncrementar;
    }
    void QuitarPoderes(Notification notificacion)
    {
        velocidad = 7;
        fuerzaSalto = 8;

    }
    private void FixedUpdate()
    {
        if (corriendo)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
        }
        animator.SetFloat("VelocidadX", GetComponent<Rigidbody2D>().velocity.x);
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
        animator.SetBool("isGrounded", enSuelo);
        if (enSuelo)
        {
            dobleSalto = false;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (corriendo)
            {
                if (enSuelo || !dobleSalto)
                {
                    GetComponent<AudioSource>().Play();
                    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaSalto);
                    if (!dobleSalto && !enSuelo)
                    {
                        dobleSalto = true;
                    }
                }
            }
            else
            {
                corriendo = true;
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeEmpiezaACorrer");
            }
        }

       
    }
}
