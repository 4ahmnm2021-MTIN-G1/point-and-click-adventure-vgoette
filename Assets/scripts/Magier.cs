using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magier : MonoBehaviour
{

    public string Character;
    public int Characterage;
    public float Characterheight;
    public bool Characterissleeping;

    public Camera cam;
    public GameObject go;
    public BoxCollider bc;
    public Rigidbody rb;
    public Text text;
    // Start is called before the first frame update
    public void Start()
    {
        Character = "Rodulf";
        Characterage = 20;
        Characterheight = 3f;
        Characterissleeping = true;

     

        go.name = "NeuerName";

        bc.isTrigger = true;

        rb.useGravity = false;
        rb.mass = 80;

        text.fontSize = 23;
        text.text = "hewohewo";
        
    }

    
}
