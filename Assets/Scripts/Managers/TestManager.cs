using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    [SerializeField] private PlaceData placeData;
    [SerializeField] private PlaceDataView placeDataView;
    // Start is called before the first frame update
    void Start()
    {

        InjectReferences();
    }
    [ContextMenu("Display data")]
    private void InjectReferences()
    {
        placeDataView.AssignData(placeData);
    }
}
