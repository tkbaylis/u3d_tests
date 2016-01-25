using UnityEngine;
using System.Collections;

public class hide_button : MonoBehaviour {

    public GameObject[] allPins;
    public GameObject featuresPanel;

    // Use this for initialization
    void Start () {
        // Instantiate all pins
        allPins = GameObject.FindGameObjectsWithTag("pin");  // this might be too slow

        // Get parent panel if not provided?  // !!!
        //featuresPanel = gameObject.transform.parent;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {

        Debug.Log("THe button was pressed");

        // Show all pins again
        foreach (GameObject pin in allPins)
        {
            pin.SetActive(true);
        }

        // Hide feature panel, if any
        if (!(featuresPanel == null))
            featuresPanel.SetActive(false);
    }
}
