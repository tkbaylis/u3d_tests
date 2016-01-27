using UnityEngine;
using System.Collections;

public class HideAllFeatures : MonoBehaviour {

    public void hideAllFeatures()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
