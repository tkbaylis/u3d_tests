using UnityEngine;
using System.Collections;

public class HideAllPanels : MonoBehaviour {

    public void hideAllPanels()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
