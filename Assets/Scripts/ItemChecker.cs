using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChecker : MonoBehaviour
{
    public bool ironIngot = false;
    public bool goldIngot = false;
    public bool blackIngot = false;
    public bool redIngot = false;
    public bool greenIngot = false;
    public bool blueIngot = false;
    public GameObject helmetConfirm;
    public GameObject shieldConfirm;
    public GameObject swordConfirm;
    
    void Start()
    {
        helmetConfirm.SetActive(false);
        shieldConfirm.SetActive(false);
        swordConfirm.SetActive(false);
    }
    void Update() 
    {
        CheckActiveHelmet();
        CheckActiveShield();
        CheckActiveSword();
    }

    public void CheckActiveHelmet()
    {
        if(ironIngot == true && goldIngot == true && blackIngot == true)
        {
            helmetConfirm.SetActive(true);
        }

        else
        {
            helmetConfirm.SetActive(false);
        }   
    }

    public void CheckActiveShield()
    {
        if(redIngot == true && blueIngot == true && greenIngot == true)
        {
            shieldConfirm.SetActive(true);
        }

        else
        {
            shieldConfirm.SetActive(false);
        }
    }

    public void CheckActiveSword()
    {
        if(redIngot == true && ironIngot == true && goldIngot == true)
        {
            swordConfirm.SetActive(true);
        }

        else
        {
            swordConfirm.SetActive(false);
        }
    }
}