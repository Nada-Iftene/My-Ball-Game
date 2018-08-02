using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptObjects : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(100, 0, 100) * Time.deltaTime);


    }
}
