﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minuspoin : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		ScoreTextScript.poinAmount -= 10;
		Destroy (gameObject);
	}

}