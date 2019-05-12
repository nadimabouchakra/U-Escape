using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildPlateScript : MonoBehaviour {


    [HideInInspector]
    public int rockCount = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CollisionDetected(RockScript child)
    {
        rockCount++;
    }

    void OnCollisionEnter(Collision collision)
    {
        transform.parent.GetComponent<CheckBalance>().CollisionDetected(this);
    }
}
