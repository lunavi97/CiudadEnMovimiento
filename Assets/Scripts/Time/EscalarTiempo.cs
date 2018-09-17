using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalarTiempo : MonoBehaviour {

    public float escalaTiempo = 1;
	void Update () {
        Time.timeScale = escalaTiempo;
	}
}
