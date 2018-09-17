using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarHacia : MonoBehaviour {

    public Transform objetivo;
	void Update () {
        transform.LookAt(objetivo);
	}
}
