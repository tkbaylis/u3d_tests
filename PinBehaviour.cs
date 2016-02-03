using UnityEngine;
using System.Collections;

public class PinBehaviour : MonoBehaviour {

    public GameObject allPins;
    public GameObject previewPanel;
    public GameObject infoPanel;
    public GameObject featuresObjects;

	// Use this for initialization
	void Start () {
        
        // Instantiate main allPins parent, if not provided
        if (allPins == null)
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

    public void OnMouseUp()
    {
        // Hide all child pins of allPins parent object
        int childCount = allPins.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            GameObject pin = allPins.transform.GetChild(i).gameObject;
            if (pin.name != gameObject.name)
                pin.SetActive(false);
        }

        // Display info panel, if any
        if (!(infoPanel == null))
            infoPanel.SetActive(true);

        // Display features objects, if any
        if (!(featuresObjects == null))
            featuresObjects.SetActive(true);

        // Will Debug.Log in C# yield a browser inspector alert as per regular JS?
        // YES! This shows up in the web inspector (in Firefox, at least)
        Debug.Log("Pin was clicked");
    }
}
