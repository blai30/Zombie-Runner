using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip callSound;
    
    private bool called = false;

	void Start() {
		
	}
	
	void Update() {
		if (Input.GetButtonDown("CallHeli") && !called) {
            called = true;
            print("Helicopter called");
        }
	}

}
