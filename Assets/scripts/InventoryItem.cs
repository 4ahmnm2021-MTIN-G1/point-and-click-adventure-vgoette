using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{

    public Image img;
    public InteractableObject io;
    public Text txt;

   public void Update()
    {

        if (img.sprite == io.sr.sprite)
        {
            Debug.Log("worked");
            txt.text = "Das Item wurde gefunden";
        }
    }
}
