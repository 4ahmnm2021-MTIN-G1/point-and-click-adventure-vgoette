using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
   
    public InteractableObject activeIO;
    public Text dialogFenster;
    public Button btn_Collect;


    public void DisplayText()
    {
        activeIO.Inspect();
        activeIO.CommandMenu.active = false;
    }

    public void Exit()
    {
        dialogFenster.text = "";
        activeIO.CommandMenu.active = false;

    }

    public void CollectItem()
    {

        activeIO.Collect();
        activeIO.CommandMenu.active = false;


    }

}
