using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{

    public GameObject CommandMenu;
    public Transform reposition;
    public UiManager uimanager;
    public Text dialogFenster;
    public string inspectText;

    public SpriteRenderer sr;
    public Image img;

    public void Start()
    {
    CommandMenu.active = false;
    }

    public void Update()
    {
        
    }

    public void OnMouseDown()
    {
        CommandMenu.active = true;
        CommandMenu.transform.position = reposition.position;

        uimanager.activeIO = this;
       // dialogFenster.text = inspectText;

        
        //commandMenu   -> muss ein GemoObject angegeben werden (Variablen u. funktionen
        //commandMenu.transform -> muss ein Transform angegeben werden vom game object
    }

  

}