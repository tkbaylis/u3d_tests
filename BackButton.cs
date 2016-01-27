using UnityEngine;
using System.Collections;

/*
 * LEGACY CLASS. See instead ShowAllPins, HideAllPanels, HideAllFeatures
 */
public class BackButton : MonoBehaviour {

    ///*
    // * Assumes that allPins is the parent of all child pins 
    // */
    //public void showAllPins(GameObject allPins)
    //{
    //    foreach (Transform child in allPins.transform)
    //    {
    //        child.gameObject.SetActive(true);
    //    }
    //}

    ///*
    // * Assumes allFeatures is the parent of all feature groups
    // */
    //public void hideAllFeatures(GameObject allFeatures)
    //{
    //    // Hide all child of parent object
    //    int childCount = allFeatures.transform.childCount;
    //    for (int i = 0; i < childCount; i++)
    //    {
    //        GameObject fgroup = allFeatures.transform.GetChild(i).gameObject;
    //        if (fgroup.name != gameObject.name)
    //            fgroup.SetActive(false);
    //    }
    //}

    ///*
    // * Assumes allPanels is the parent of all panel groups
    // */
    //public void hideAllPanels(GameObject allPanels)
    //{
    //    // Hide all child of parent object
    //    int childCount = allPanels.transform.childCount;
    //    for (int i = 0; i < childCount; i++)
    //    {
    //        GameObject pgroup = allPanels.transform.GetChild(i).gameObject;
    //        if (pgroup.name != gameObject.name)
    //            pgroup.SetActive(false);
    //    }
    //}
}
