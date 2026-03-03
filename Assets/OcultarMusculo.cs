using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarGrupoMuscular : MonoBehaviour
{
    public Material Muscle_Mat;
    public GameObject[] musculosDelGrupo;

    private static MostrarGrupoMuscular grupoActivo = null;

    public void MostrarGrupo()
    {
        Renderer[] todos = FindObjectsOfType<Renderer>();

        // Si presiono el mismo botón → restaurar todo
        if (grupoActivo == this)
        {
            foreach (Renderer r in todos)
            {
                foreach (Material m in r.sharedMaterials)
                {
                    if (m == Muscle_Mat)
                    {
                        r.enabled = true;
                        break;
                    }
                }
            }

            grupoActivo = null;
            return;
        }

        // Ocultar todos los músculos
        foreach (Renderer r in todos)
        {
            foreach (Material m in r.sharedMaterials)
            {
                if (m == Muscle_Mat)
                {
                    r.enabled = false;
                    break;
                }
            }
        }

        // Mostrar grupo seleccionado
        foreach (GameObject musculo in musculosDelGrupo)
        {
            Renderer r = musculo.GetComponentInChildren<Renderer>();
            if (r != null)
                r.enabled = true;
        }

        grupoActivo = this;
    }
}
