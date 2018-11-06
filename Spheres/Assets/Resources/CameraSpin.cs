using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpin : MonoBehaviour {

    public float spinSpeed;

	void Update () {
        //Camera movement control
        transform.Rotate(Vector3.right * Time.deltaTime * spinSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * spinSpeed);
    }
}
