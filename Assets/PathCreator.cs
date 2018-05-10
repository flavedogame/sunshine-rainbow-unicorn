using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(LineRenderer))]
public class PathCreator : MonoBehaviour {
	private LineRenderer lineRenderer;
	public List<Vector3> points = new List<Vector3> ();
	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			//Debug.Log ("fire!");
			points.Clear ();
		}
		if (Input.GetButton ("Fire1")) {
			Vector3 mouseLoc = Camera.main.ScreenToWorldPoint (Input.mousePosition) + new Vector3 (0,0,10.0f);
			//Debug.Log ("mouseLoc" + mouseLoc);
			if (DistanceToLastPoint (mouseLoc)) {
				//Debug.Log ("draw it");
				points.Add (mouseLoc);
				lineRenderer.positionCount = points.Count;
				lineRenderer.SetPositions (points.ToArray ());
			}
		}
	}

	bool DistanceToLastPoint(Vector3 point){
		return true;
	}
}
