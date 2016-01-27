using UnityEngine;
using System.Collections;

public class HideAllFeatures : MonoBehaviour {

    public void hideAllFeatures()
    {
        // !!! Must be a faster way
        GameObject allFeatures = GameObject.FindGameObjectWithTag("allFeatures");

        // Hide all child of parent object
        int childCount = allFeatures.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            GameObject fgroup = allFeatures.transform.GetChild(i).gameObject;
            if (fgroup.name != gameObject.name)
                fgroup.SetActive(false);
        }
    }
}
