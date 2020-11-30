using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
   
    public InteractableObject activeIO;
    public Text dialogFenster;


    public void DisplayText()
    {
        dialogFenster.text = activeIO.inspectText;
    }

    public void Exit()
    {
        dialogFenster.text = "";
    }

    public void CollectItem()
    {
        Debug.Log("ldfdfjdkfjd");

        activeIO.img.sprite = activeIO.sr.sprite;
    }

}
