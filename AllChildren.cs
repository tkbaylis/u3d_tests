using UnityEngine;
using System.Collections;

public class AllChildren : MonoBehaviour {

    // Show all the current object's children
    public void showAll()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    // Hide all the current object's children
    public void hideAll()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
