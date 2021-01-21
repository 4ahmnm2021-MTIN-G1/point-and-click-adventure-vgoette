using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{

    public GameObject CommandMenu;
    public Transform reposition;
    public UiManager uimanager;
    public Text dialogFenster;



    public bool collectible;

    public UnityEvent inspect;
    public UnityEvent isCollectable;
    public UnityEvent isNotCollectable;

    public void Start()
    {
    CommandMenu.active = false;
    }

   
    public void OnMouseDown()
    {
        CommandMenu.active = true;
        CommandMenu.transform.position = reposition.position;

        uimanager.activeIO = this;
 

        
        //commandMenu   -> muss ein GemoObject angegeben werden (Variablen u. funktionen
        //commandMenu.transform -> muss ein Transform angegeben werden vom game object


        if (collectible)
        {
            uimanager.btn_Collect.interactable = true;
        }
        else
        {
            uimanager.btn_Collect.interactable = false;
        }
    }

    public void Inspect()
    {
        inspect.Invoke();
    }

    public void Collect()
    {
        if (collectible)
        {
            isCollectable.Invoke();
        }

        else
        {
            isNotCollectable.Invoke();
        }
    }
  
    public void SetCollectable(bool value)
    {
        collectible = value;
    }
}