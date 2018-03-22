using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip callSound;
    
    private bool called = false;
    private AudioSource audioSource;

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}
	
	void Update() {
		if (Input.GetButtonDown("CallHeli") && !called) {
            called = true;
            Debug.Log("Helicopter called");
            audioSource.clip = callSound;
            audioSource.Play();
        }
	}

}
