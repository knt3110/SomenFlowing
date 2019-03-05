using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Somen4 : MonoBehaviour {

	void Update () {
        gameObject.transform.position += new Vector3(0.021f, -0.047f, 0f);
        gameObject.transform.localScale += new Vector3(0.005f, 0.005f, 0.005f);
    }
}
