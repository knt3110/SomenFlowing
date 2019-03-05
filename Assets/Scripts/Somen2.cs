using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Somen2 : MonoBehaviour {
	
	void Update () {
        gameObject.transform.position += new Vector3(-0.007f, -0.048f, 0f);
        gameObject.transform.localScale += new Vector3(0.005f, 0.005f, 0.005f);
	}
}
