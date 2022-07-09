using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="PlaceData", menuName ="Data/PlaceData")]
public class PlaceData : ScriptableObject
{
    public string Author;
    public string Name;
    public string Date;
    //public Sprite image;
    public string imageName;
    public string Description;

}
