using UnityEngine;
using System.Collections;

public class ShowAllPins : MonoBehaviour {

    public void showAllPins()
    {
        // !!! Must be a faster way
        GameObject allPins = GameObject.FindGameObjectWithTag("allPins");

        foreach (Transform child in allPins.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
