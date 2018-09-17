using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoPasado : MonoBehaviour {

    public float tiempoPasado;
	void Update () {
        tiempoPasado = Time.realtimeSinceStartup;
	}
}
