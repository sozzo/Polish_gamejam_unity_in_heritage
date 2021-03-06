using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlaceDataView : MonoBehaviour
{
    [SerializeField] private TMP_Text description;
    [SerializeField] private Image image;

    private PlaceData placeData;
    public void AssignData(PlaceData placeData)
    {
        this.placeData = placeData;
        description.text = placeData.Description;
        image.sprite = placeData.image;
    }
}
