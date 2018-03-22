using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip callSound;
    
    private bool called = false;
    private AudioSource audioSource;
    private Rigidbody rigidBody;

	void Start() {
		audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
	}

    public void Call() {
        if (!called) {
            called = true;
            Debug.Log("Helicopter called");
            audioSource.clip = callSound;
            audioSource.Play();
            rigidBody.velocity = new Vector3(0, 0, 50f);
        }
    }

}
