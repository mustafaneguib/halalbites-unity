using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovement : MonoBehaviour {

    public static bool stopUpMovementNow=false;
    public static bool stopDownMovementNow=false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider trigger)
    {

        
        Debug.Log("triggered");
        //Debug.Log(trigger.transform.position);
        //trigger.transform.position= new Vector3(0, 0);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(gameObject.name.CompareTo("Top Notch") == 0)
        {
            stopDownMovementNow = true;
        }
        else if (gameObject.name.CompareTo("Bottom Notch") == 0)
        {
            stopUpMovementNow = true;
        }
                    
        Debug.Log(collision.transform.position);
        Debug.Log("collided");
        

    }
    

}
