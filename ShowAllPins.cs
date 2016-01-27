using UnityEngine;
using System.Collections;

public class ShowAllPins : MonoBehaviour {

    public void showAllPins()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
