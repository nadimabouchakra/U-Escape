using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBalance : MonoBehaviour {


    [SerializeField]
    public GameObject plateLeft;
    [SerializeField]
    public GameObject plateRight;
    [SerializeField]
    public GameObject AmisDoor;





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlateChecker() == true)
        {
            AmisDoor.SetActive(false);   
        }
	}

    bool PlateChecker()
    {
        if((plateRight.GetComponent<ChildPlateScript>().rockCount == plateLeft.GetComponent<ChildPlateScript>().rockCount) && plateLeft.GetComponent<ChildPlateScript>().rockCount > 1 && plateRight.GetComponent<ChildPlateScript>().rockCount > 1)
        {
            return true;
        }
        return false;
    }



    public void CollisionDetected(ChildPlateScript child)
    {
        
    }

}
