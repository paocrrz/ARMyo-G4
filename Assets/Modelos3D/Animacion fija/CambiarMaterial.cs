using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarMaterial : MonoBehaviour
{
    public Material materialSeleccionado;

    private Material materialOriginal;
    private Renderer rend;
    private bool cambiado = false;

    void Start()
    {
        rend = GetComponentInChildren<Renderer>();
        materialOriginal = rend.material; //Guardamos el original   
    }

    // Update is called once per frame
    public void AlternarMaterial()
    {
        if (cambiado)
        {
            rend.material = materialOriginal;
        }
        else
        {
            rend.material = materialSeleccionado;
        }
        cambiado = !cambiado; // Alternamos el estado
    }
}
