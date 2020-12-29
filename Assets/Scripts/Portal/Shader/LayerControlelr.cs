using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerControler : MonoBehaviour
{
    public Renderer[] portals;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        List<Renderer> renders = new List<Renderer>(portals);

        for (int i = 0; i < portals.Length; i++)
        {
            Renderer ren;
            float greaterValue = 0;
            foreach (Renderer render in renders)
            {
                if (greaterValue < Vector3.Distance(render.transform.position, player.position))
                {
                    renders.Remove(render);
                    break;
                }
            }

            ren.material.SetInt("Layer", i);
        }

     }
    }
}
