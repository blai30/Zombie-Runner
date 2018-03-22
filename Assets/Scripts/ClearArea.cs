using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

    public float timeSinceLastTrigger = 0f;

	void Start() {
		
	}
	
	void Update() {
		timeSinceLastTrigger += Time.deltaTime;

        if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f) {
            SendMessageUpwards("OnFindClearArea");
        }
	}

    void OnTriggerStay() {
        timeSinceLastTrigger = 0f;
    }

}
