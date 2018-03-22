using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints; // Parent of the spawn points
    public bool respawn = false;
    public Helicopter helicopter;
    public AudioClip whatHappened;

    private Transform[] spawnPoints;
    private bool lastToggle = false;
    private AudioSource innerVoice;

	void Start() {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();

        AudioSource[] audioSources = GetComponents<AudioSource>();
        foreach (AudioSource audioSource in audioSources) {
            if (audioSource.priority == 1) {
                innerVoice = audioSource;
            }
        }

        innerVoice.clip = whatHappened;
        innerVoice.Play();
	}
	
	void Update() {
        if (lastToggle != respawn) {
            Respawn();
            respawn = false;
        } else {
            lastToggle = respawn;
        }
	}

    private void Respawn() {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }

    void OnFindClearArea() {
        Debug.Log("Found clear area in player");
        helicopter.Call();
    }

}
