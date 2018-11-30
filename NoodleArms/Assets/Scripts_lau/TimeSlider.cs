﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour {

    public Slider slider;
    public float time = 30f;

	// Use this for initialization
	void Start () {

        slider.maxValue = 30f;
        slider.minValue = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {

        time -= Time.deltaTime;
        slider.value = time;
		
	}
}
