using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "rightPlate" || collision.gameObject.name == "leftPlate")
        {
            transform.parent.Find("scale_3.5/leftPlate").GetComponent<ChildPlateScript>().CollisionDetected(this);
            transform.parent.Find("scale_3.5/rightPlate").GetComponent<ChildPlateScript>().CollisionDetected(this);
        }

    }
}
