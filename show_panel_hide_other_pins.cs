using UnityEngine;
using System.Collections;

public class show_panel_hide_other_pins : MonoBehaviour {

    public GameObject[] allPins;
    public GameObject panelGroup;

	// Use this for initialization
	void Start () {

        // Instantiate all pins
        allPins = GameObject.FindGameObjectsWithTag("pin");  // this might be too slow

        // Hide panel group, if any
        if (panelGroup == null)
        {
            return;
        }
        else
        {
            panelGroup.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseEnter()
    {
        // Hide all other pins
        foreach (GameObject pin in allPins)
        {
            if (pin.name != gameObject.name)
            {

                pin.SetActive(false);
            }
        }

        // Display panel group, if any
        if (panelGroup == null)
        {
            return;
        }
        else
        {
            panelGroup.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        // Show all pins again
        foreach (GameObject pin in allPins)
        {
            pin.SetActive(true);
        }

        // Hide panel group, if any
        if (panelGroup == null)
        {
            return;
        }
        else
        {
            panelGroup.SetActive(false);
        }
    }

    void OnMouseDown()
    {

    }
}
