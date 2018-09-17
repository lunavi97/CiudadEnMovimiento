using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Constructor : MonoBehaviour {

    public Vector3 nuevoVector = new Vector3(0, 0, 0);
    void Update ()
    {
        transform.position = nuevoVector;
    }
}
