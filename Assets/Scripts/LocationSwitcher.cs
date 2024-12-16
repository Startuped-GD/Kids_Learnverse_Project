using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationSwitcher : MonoBehaviour
{
    [Header("LOCATION")]
    public GameObject buildingPrefabe;
    public GameObject anotherLocationSwitcher;
    public Transform newLocation { get; private set; }
    private Transform locationSwitcherPos;

    // Building Details 
    [Header("BUILDING INSIDE")]
    public Sprite buildingSprites; 
    public List<Vector2> bordesrPosition = new(); 

    private void Start()
    {
        newLocation = buildingPrefabe.transform.Find("Player Entery Location").transform;
        locationSwitcherPos = buildingPrefabe.transform.Find("Location Switcher Position").transform; 
    }

    public void SpawnBuilding()
    {

    }
}
