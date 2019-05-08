using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DoorControl : MonoBehaviour {

    [HideInInspector]
    public bool isClosed = false;
    [HideInInspector]
    public bool alreadyPlayed = false;
    [HideInInspector]
    public bool isRoomFinished = false;
    [SerializeField]
    public GameObject doorToControl;
    [SerializeField]
    public AudioSource doorClose;
   

    // Use this for initialization
    void Start () {
        doorToControl.SetActive(false);
        /*
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        */
	}
	
	// Update is called once per frame
	void Update () {
      
	}
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("KIIIIIIIIIISSSSSSSSSSSSSSS EMMMMMMMMMMMAKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");

        if(other.transform.root.name == "[VRTK_SDKManager]")
        {
            doorToControl.SetActive(true);
            if(alreadyPlayed == false)
            {
                doorClose.Play();
            }
            alreadyPlayed = true;
        }
       
    }
}
