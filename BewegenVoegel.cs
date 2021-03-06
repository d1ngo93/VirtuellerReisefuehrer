﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegenVoegel : MonoBehaviour {



	// Bei dieser Funktion werden Ziele erzeugt, die ein GameObject ansteuert. Es wird zusätzlich eine Variable für die Geschwindigkeit des Objekts, welches diese
	// FUnktion nutzt, erzeugt.

	public Transform[] target;
	public float speed;

	private int current;

	//Bei jedem Update wird überprüft, ob sich das Objekt bereits am Ziel befindet, oder sich eine Einheit weiterbewegen soll.

	void Update() {
		if (transform.position != target [current].position) {
			Vector3 pos = Vector3.MoveTowards (transform.position, target [current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody> ().MovePosition (pos);
		}  else
			current = (current + 1) % target.Length;
	}
}
