using UnityEngine;
using System.Collections;

public class show_panel_hide_other_pins : MonoBehaviour {

    public GameObject[] allPins;
    public GameObject previewPanel;
    public GameObject featuresPanel;

	// Use this for initialization
	void Start () {

        // Instantiate all pins
        allPins = GameObject.FindGameObjectsWithTag("pin");  // this might be too slow

        // Hide preview panel, if any
        if (!(previewPanel == null))
            previewPanel.SetActive(false);

        // Hide panel group, if any
        if (!(featuresPanel == null))
            featuresPanel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseEnter()
    {
        // Display preview panel, if any
        if (!(previewPanel == null))
            previewPanel.SetActive(true);
    }

    void OnMouseExit()
    {
        // Hide preview panel, if any
        if (!(previewPanel == null))
            previewPanel.SetActive(false);
    }

    void OnMouseDown()
    {
        // Hide all other pins
        foreach (GameObject pin in allPins)
        {
            if (pin.name != gameObject.name)        
                pin.SetActive(false);
        }

        // Display panel group, if any
        if (!(featuresPanel == null))
            featuresPanel.SetActive(true);
    }
}
