 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFromCamera : MonoBehaviour {

	public Camera camera;
	public Canvas canvas;
	public Vector3 HitPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			HitPoint = hit.point;
			canvas.planeDistance = Vector3.Distance (hit.point, transform.position);
		}
	}
}
