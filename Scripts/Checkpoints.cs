using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    //---------------------External
    public GameObject cp1;
    public GameObject cp2;
    public GameObject cp3;
    public GameObject cp4;
    public GameObject cp5;
    public GameObject cp6;
    public GameObject cp7;
    public GameObject cp8;
    public GameObject fnsh;
    //---------------------
    
    void Start()
    {
        //Disable Mesh renderers
        cp1.GetComponent<MeshRenderer>().enabled = false;
        cp2.GetComponent<MeshRenderer>().enabled = false;
        cp3.GetComponent<MeshRenderer>().enabled = false;
        cp4.GetComponent<MeshRenderer>().enabled = false;
        cp5.GetComponent<MeshRenderer>().enabled = false;
        cp6.GetComponent<MeshRenderer>().enabled = false;
        cp7.GetComponent<MeshRenderer>().enabled = false;
        cp8.GetComponent<MeshRenderer>().enabled = false;
        fnsh.GetComponent<MeshRenderer>().enabled = false;

    }
}
