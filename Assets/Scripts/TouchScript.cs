using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //check for touches on screen
        if(Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                //shooting raycast where screen touched
                Ray ray=Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.collider != null)
                    {
                        //if raycast hits smth - access object's collider and mesh & change color
                        Color color = new Color(Random.value, Random.value, Random.value);
                        hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = color;
                    }
                }
            }
        }
    }
}
