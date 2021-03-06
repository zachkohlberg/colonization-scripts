﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedBuilding : UISelected {

    public Text resourceConsumption, resourceProduction, status; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        UISelectedUpdate();

        if (GetSelected().Tag == "Beacon")
        {
            Beacon b = GetSelected().GetComponent<Beacon>();
            //radius
            resourceProduction.text =/* "-" + */b.PowerRate.ToString();
            //power consumed per second
            resourceConsumption.text = b.Radius.ToString();
        }

        else if (GetSelected().Tag == "Factory")
        {
            Factory f = GetSelected().GetComponent<Factory>();
            //factory does not currently have/say anything about itself.
            resourceProduction.text = "";
            resourceConsumption.text = "";
            
        }
        else if (GetSelected().Tag == "Farm")
        {
            Farm f = GetSelected().GetComponent<Farm>();
            //consuming mass
            resourceConsumption.text =/* "-" + */f.MassRate.ToString();
            //producing food
            resourceProduction.text = "+" + f.FoodRate.ToString();
        }
        else if (GetSelected().Tag == "PowerPlant")
        {
            PowerPlant p = GetSelected().GetComponent<PowerPlant>();
            //consume mass
            resourceConsumption.text =/* "-" + */p.MassRate.ToString();
            //produce power
            resourceProduction.text = "+" + p.PowerRate.ToString();
        }
        else if (GetSelected().Tag == "Base")
        {
            Base b = GetSelected().GetComponent<Base>();
            //consuming food
            resourceConsumption.text = b.FoodRate.ToString();
            //consuming power
            resourceProduction.text = b.PowerRate.ToString();
        }
        else if (GetSelected().Tag == "Victory")
        {
            //do nothing.
        }

        Debug.Log("The object is active and enabled: " + GetSelected().isActiveAndEnabled);
        if (GetSelected().On)
        {
            status.text = "Active";
        }
        else
        {
            status.text = "Inactive";
        }
        
	}
}
