using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

    public void showAllPins(GameObject pinsParent)
    {
        foreach (Transform child in pinsParent.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    public void hideFeaturesObjects(GameObject featuresObjects)
    {
        featuresObjects.SetActive(false);
    }

    public void hideInfoPanel(GameObject infoPanel)
    {
        infoPanel.SetActive(false);
    }
}
