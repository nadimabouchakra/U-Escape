using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TableChecker : MonoBehaviour
{
    //This is the door of the room
    [SerializeField]
    public GameObject door;

    

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(transform.position.x);
        //Debug.Log("I'm attached to " + gameObject.name);

    }

    // Update is called once per frame 
    void Update()
    {

         if(CheckAllTables() == true)
        {
          door.SetActive(false);
        }

        /*
         * 
         *         if(gameObject.GetComponent<IsTableOn>().hasTable == true)
        {
            door.SetActive(false);
        }
         * 
        foreach (Transform table in transform)
        {
            Debug.Log(table.name);
        }
        if (transform.Find("Table 1"))
        {
            Debug.Log("Found first table");
        }
        */
    }

    bool CheckAllTables()
    {
        GameObject[] spots = GameObject.FindGameObjectsWithTag("Spot"); ;
        foreach (GameObject spot in spots)
        {
            
            if(spot.GetComponent<IsTableOn>().hasTable == false)
            {
                return false;
            }
        }
        Debug.Log("ALL THE TABLES ARE IN THE RIGHT SPOTS !!!!!! HORRRAYYYYYYYY!!!!!!");

        return true;
    }

   

    //make method that returns the patch ground transform

    //make a third method that checks if the location for a given table and location is equal
    //or we can use the isTrigger() or some other function that will be called on collision
    //we can make it so that on collision it updates a boolean flag which is a dtaamember,Then
    //here the function would just check for all flags to be true in order to do something




}
