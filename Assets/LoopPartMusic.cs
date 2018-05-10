using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPartMusic : MonoBehaviour {
	AudioSource audioSource;

	public float startPoint = 60+41;
	public float endPoint = 60+50;


	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.time = startPoint;
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (endPoint!=-1 && audioSource.time >= endPoint) {
			audioSource.time = startPoint;
		}
	}
}
