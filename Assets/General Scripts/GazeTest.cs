using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeTest : MonoBehaviour {

    public Material onFocusMat;
    public Material offFocusMat;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = offFocusMat;
	}
	
	public void OnFocus()
    {
        GetComponent<Renderer>().material = onFocusMat;
    }

    public void OffFocus()
    {
        GetComponent<Renderer>().material = offFocusMat;
    }
}
