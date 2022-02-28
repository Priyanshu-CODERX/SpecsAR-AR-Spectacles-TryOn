using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    public Color[] color;
    public Renderer[] specs;

    public void Red()
    {
        for (int i = 0; i < specs.Length; i++)
            specs[i].material.color = color[0];
    }
    public void Green()
    {
        for (int i = 0; i < specs.Length; i++)
            specs[i].material.color = color[1];
    }
    public void Blue()
    {
        for (int i = 0; i < specs.Length; i++)
            specs[i].material.color = color[2];
    }
    public void Black()
    {
        for (int i = 0; i < specs.Length; i++)
            specs[i].material.color = color[3];
    }

}
