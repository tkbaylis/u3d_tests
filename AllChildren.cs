using UnityEngine;
using System.Collections;

public class AllChildren : MonoBehaviour {

    public void showAll()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    public void hideAll()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
