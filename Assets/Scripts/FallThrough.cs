﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallThrough : MonoBehaviour {


	void Start () {
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Shootable"), LayerMask.NameToLayer("Shootable"));
	}
	

	void Update () {
		
	}
}
