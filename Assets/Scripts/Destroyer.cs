﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
	void Update () {
        if (Pplayer.lose)
        {
            Destroy(gameObject);
        }
	}
}
