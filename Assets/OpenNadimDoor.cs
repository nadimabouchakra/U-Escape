using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNadimDoor : MonoBehaviour {

    //This is the door of the room
    [SerializeField]
    public GameObject door;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("KIIIIIIIIIISSSSSSSSSSSSSSS EMMMMMMMMMMMAKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");

        if (other.transform.root.name == "[VRTK_SDKManager]")
        {
            door.SetActive(false);
        }

    }
}
