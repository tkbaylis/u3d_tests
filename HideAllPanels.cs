using UnityEngine;
using System.Collections;

public class HideAllPanels : MonoBehaviour {

    public void hideAllPanels()
    {
        // !!! Must be a faster way
        GameObject allPanels = GameObject.FindGameObjectWithTag("allPanels");

        // Hide all child of parent object
        int childCount = allPanels.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            GameObject pgroup = allPanels.transform.GetChild(i).gameObject;
            if (pgroup.name != gameObject.name)
                pgroup.SetActive(false);
        }
    }
}
