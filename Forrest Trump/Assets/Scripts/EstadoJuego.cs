using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuego : MonoBehaviour
{
    public int puntuacionMaxima = 0;
    public static EstadoJuego estadoJuego;
    private string rutaArchivo;
    void Awake()
    {
        rutaArchivo = Application.persistentDataPath + "/datos.dat";
        if(estadoJuego == null)
        {
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }else if(estadoJuego != this)
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        Cargar();
    }

    
    void Update()
    {
        
    }

    void Cargar()
    {
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);

            DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);

            puntuacionMaxima = datos.puntuacionMaxima;

            file.Close();
        }
        else
        {
            puntuacionMaxima = 0;
        } 
    }
    public void Guardar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create (rutaArchivo);

        DatosAGuardar datos = new DatosAGuardar();
        datos.puntuacionMaxima = puntuacionMaxima;

        bf.Serialize(file, datos);

        file.Close();

    }

}

[Serializable]
    class DatosAGuardar
    {
        public int puntuacionMaxima;

       
    }

