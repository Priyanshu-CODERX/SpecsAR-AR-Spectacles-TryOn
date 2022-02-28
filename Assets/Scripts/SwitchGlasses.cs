using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGlasses : MonoBehaviour
{
    public GameObject glass1;
    public GameObject glass2;
    public GameObject glass3;

    public void ActivateGlass1()
    {
        glass1.SetActive(true);
        glass2.SetActive(false);
        glass3.SetActive(false);
    }

    public void ActivateGlass2()
    {
        glass1.SetActive(false);
        glass2.SetActive(true);
        glass3.SetActive(false);
    }

    public void ActivateGlass3()
    {
        glass1.SetActive(false);
        glass2.SetActive(false);
        glass3.SetActive(true);
    }

}
