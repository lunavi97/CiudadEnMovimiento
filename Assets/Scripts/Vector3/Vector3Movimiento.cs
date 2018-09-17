using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Movimiento : MonoBehaviour {

    public Vector3 adelante = Vector3.forward;
    public Vector3 atras = Vector3.back;
    private bool irAdelante = true;
	void Update () {
        if (irAdelante)
        {
            if (transform.position.z < 275)
                transform.position += adelante;
            else irAdelante = false;
        }

        else if (transform.position.z > -40)
        {
            transform.position += atras;
        }

        else irAdelante = true;
	}
}
