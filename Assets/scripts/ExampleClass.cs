using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public int order;
    public float massscale;
    public string objectName;
    public bool audioloop;

    public Rigidbody rbVariable;
    public HingeJoint hjVariable;
    public AudioSource asVariable;
    public SpriteRenderer srVariable;
    public ExampleClass x;
    public GameObject gameo;

    private void Start()
    {

        hjVariable.massScale = massscale;
        srVariable.sortingOrder = order;
        gameo.name = objectName;
        asVariable.loop = audioloop;
    }



}
