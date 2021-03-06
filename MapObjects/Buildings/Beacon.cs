﻿using UnityEngine;
using System.Collections;

public class Beacon : Building {
	
	private LightObject light;
	
	//Public properties
	public float Radius {
		get { return manager.Stat(tag+"Radius"); }
	}
	new public float PowerRate {
		get { return (On)?manager.Stat(tag+"PowerRate"):0; }
	}
	
	private void Awake() {
        BeaconInit();
    }
    
	private void BeaconInit() {
		BuildingInit();
		light = GetComponentInChildren<LightObject>();
    	tag = "Beacon";
    }
    
    private void Update() {
		if (On) {
			if (!manager.SpendPower(-PowerRate*Time.deltaTime)) {
				On = false;
				light.ShrinkLight();
			}
			if (light.On) {
				light.GrowLight();
			}
        }
        else {
        	if (!light.On) {
        		light.ShrinkLight();
        	}
        }
    }
}
