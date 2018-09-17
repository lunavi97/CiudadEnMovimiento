using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDelta : MonoBehaviour {

    public float seg;
	void Update () {
        seg += Time.deltaTime;
	}
}
