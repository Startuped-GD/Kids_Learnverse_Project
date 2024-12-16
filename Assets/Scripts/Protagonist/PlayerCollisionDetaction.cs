using UnityEngine;

public class PlayerCollisionDetaction : MonoBehaviour
{
    private LocationSwitch playerLocationSwitchSystem;
    private Lv1Manager level1; 

    private void Start()
    {
        playerLocationSwitchSystem = GetComponent<LocationSwitch>();   
        level1 = GameObject.Find("Lv1 Manager").GetComponent<Lv1Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collisionDetails)
    {
        if(collisionDetails != null)
        {
            if(collisionDetails.CompareTag("Location Icon"))
            {
                Debug.Log("Location Icon");
                playerLocationSwitchSystem.EnableSwitchButton(true);
                playerLocationSwitchSystem.GetDetactedLocationSwitcher(collisionDetails.transform); 
            }

            if(collisionDetails.CompareTag("Bubble"))
            {
                Debug.Log("Its Bubble");
                Destroy(collisionDetails.gameObject);
                level1.IncreaseBubbleCollection(); 
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collisionDetails)
    {
        if(collisionDetails != null)
        {
            if(collisionDetails.CompareTag("Location Icon"))
            {
                Debug.Log("Exit Location Icon"); 
            }

            if (collisionDetails.CompareTag("Location Icon"))
            {
                Debug.Log("Location Icon");
                playerLocationSwitchSystem.EnableSwitchButton(false);
                playerLocationSwitchSystem.GetDetactedLocationSwitcher(null); 
            }
        }
    }
}
