﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeaderDataUIScript : MonoBehaviour {

    private Manager manager;
    public Text resourceMassAmount, resourceMassChange, resourceFoodAmount, resourceFoodChange, resourcePowerAmount, resourcePowerChange;

	// Use this for initialization
	void Start () {
        if (GameObject.Find("Manager") != null)
        {
            manager = GameObject.Find("Manager").GetComponent<Manager>();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// Update the values found in the header bar.
    /// </summary>
    public void HeaderUpdate()
    {
        if (manager != null)
        {
            float amt;
            string change = " ";
            //mass
            amt = manager.GetTotalRate("Mass");
            resourceMassAmount.text = ((int)manager.Mass).ToString();
            if (amt > 0)
            {
                change = "+" + ((int)amt).ToString();
            }
            else if (amt <= 0)
            {
                change = ((int)amt).ToString();
            }
            resourceMassChange.text = change;

            //food
            resourceFoodAmount.text = ((int)manager.Food).ToString();
            amt = manager.GetTotalRate("Food");
            if (amt > 0)
            {
                change = "+" + ((int)amt).ToString();
            }
            else if (amt <= 0)
            {
                change = ((int)amt).ToString();
            }

            resourceFoodChange.text = change;

            //power
            resourcePowerAmount.text = ((int)manager.Power).ToString();
            amt = manager.GetTotalRate("Power");
            if (amt > 0)
            {
                change = "+" + ((int)amt).ToString();
            }
            else if (amt <= 0)
            {
                change = ((int)amt).ToString();
            }
            resourcePowerChange.text = change;
        }
    }
}