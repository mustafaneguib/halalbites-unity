using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

    bool moveCube = true;
    Vector3 previous;
    Vector3 next;
    int direction = 0;//0: still, 1: up, 2: down
    public GameObject topNotch;
    public GameObject bottomNotch;

    private void Start()
    {

    }

    private void Update()
    {
        Debug.Log("stopDownMovementNow: "+StopMovement.stopDownMovementNow);
        Debug.Log("stopUpMovementNow: "+StopMovement.stopUpMovementNow);
    }

    IEnumerator autoScroll()
    {

        for (int i = 0; i < 100; i++)
        {

            if (direction == 1)
            {
                if (!StopMovement.stopUpMovementNow)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
                }
            }
            else if (direction == 2)
            {
                if (!StopMovement.stopDownMovementNow)
                {

                    transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
                }
            }
            yield return new WaitForSeconds(0.01f);
        }
        

        yield return new WaitForSeconds(1f);
    }

    private void OnMouseUp()
    {
        //Debug.Log("onmouseup");
        StartCoroutine(autoScroll());
    }

    private void OnMouseDrag()
    {
        //if (moveCube) { 
        /*Vector3 mousePosition = new Vector3(transform.position.x- Camera.main.transform.position.x, Input.mousePosition.y, transform.position.z - Camera.main.transform.position.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);//new Vector3(0.5f, mousePosition.y,10));

        //Debug.Log(Input.mousePosition);
        //Debug.Log(objPosition);

        transform.position = objPosition;
        //}
        */
        
       // Debug.Log("previous: "+previous);
        //Debug.Log("next: " + next);


        next = Input.mousePosition;
        
        //Debug.Log(Input.mousePosition);
        float positionY = transform.position.y- Input.mousePosition.y;
        //Debug.Log(positionY);
        
        Vector3 point = Camera.main.ScreenToWorldPoint(
                new Vector3(
                    (transform.position.x - Camera.main.transform.position.x),
                    Input.mousePosition.y,
                    (transform.position.z - Camera.main.transform.position.z)));



        if ((next.y - previous.y) > 0)
        {

            if (!StopMovement.stopUpMovementNow) { 
            transform.position = new Vector3(transform.position.x,transform.position.y+0.1f,transform.position.z);
            point.y = point.y - 0.0001f;
            //Debug.Log("up");
            direction = 1;
                StopMovement.stopDownMovementNow = false;
            }

        }
        else if((next.y - previous.y) < 0)
        {
            if (!StopMovement.stopDownMovementNow)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
                point.y = point.y + 0.0001f;
                //Debug.Log("down");
                direction = 2;
                StopMovement.stopUpMovementNow = false;
            }
        }
        else
        {
            //Debug.Log("no movement");
            direction = 0;
        }

    
        point.x = transform.position.x;
        point.z = transform.position.z;
        //point.y = positionY;
        //transform.position = point;
        previous = next;

    }


  
}
