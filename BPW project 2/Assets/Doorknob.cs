using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorknob : MonoBehaviour
{
    public GameObject Deurknop, DKTekst;
    private void Start()
    { 
        DKTekst.SetActive(false);

    }

    public void OnMouseOver()
    {
        DKTekst.SetActive(true);
    }

    public void OnMouseExit()
    {
        DKTekst.SetActive(false);
    }

    public void Quitgame()
    {
        Application.Quit();

    }
}
