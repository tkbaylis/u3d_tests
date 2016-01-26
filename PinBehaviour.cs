using UnityEngine;
using System.Collections;

public class PinBehaviour : MonoBehaviour {

    public GameObject[] allPinArray;
    public GameObject allPins;
    public GameObject previewPanel;
    public GameObject infoPanel;
    public GameObject featuresObjects;

	// Use this for initialization
	void Start () {

        // Instantiate all pin array
        allPinArray = GameObject.FindGameObjectsWithTag("pin");  // this might be too slow

        // Instantiate all pins
        allPins = GameObject.FindGameObjectWithTag("allPins");

        // Hide preview panel, if any
        if (!(previewPanel == null))
            previewPanel.SetActive(false);

        // Hide info panel, if any
        if (!(infoPanel == null))
            infoPanel.SetActive(false);

        // Hide features objects, if any
        if (!(featuresObjects == null))
            featuresObjects.SetActive(false);
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
        foreach (GameObject pin in allPinArray)
        {
            if (pin.name != gameObject.name)
                pin.SetActive(false);
        }

        // Display info panel, if any
        if (!(infoPanel == null))
            infoPanel.SetActive(true);

        // Display features objects, if any
        if (!(featuresObjects == null))
            featuresObjects.SetActive(true);
    }
}
