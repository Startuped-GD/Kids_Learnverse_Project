using UnityEngine;
using UnityEngine.UI; 

public class LocationSwitch : MonoBehaviour
{
    private GameObject LocationSwitchBTNObject;

    private Transform newLocation;
    private Transform detactedLocationSwitcher; 

    // Start is called before the first frame update
    void Start()
    {
        LocationSwitchBTNObject = GameObject.Find("Location Switch Button"); 
    }

    public void EnableSwitchButton(bool canEnable)
    {
        Button LocationSwitchButton = LocationSwitchBTNObject.transform.GetComponent<Button>();
        Image locationSwitchBtnImage = LocationSwitchBTNObject.transform.GetComponent<Image>(); 

        LocationSwitchButton.enabled = canEnable;   
        locationSwitchBtnImage.enabled = canEnable; 
    }

    //Invoke when player collide with location switch icon
    public void GetDetactedLocationSwitcher(Transform _locationSwitcher)
    {
        detactedLocationSwitcher = _locationSwitcher;
    }

    // Invoke when player click on btn 
    public void LocationSwitchConfirm()
    {
        // Get new location
        LocationSwitcher newLocationSwitcher = detactedLocationSwitcher.GetComponent<LocationSwitcher>();
        newLocation = newLocationSwitcher.newLocation;

        // Switch Position to new location
        this.transform.position = newLocation.position; 
    }
}
