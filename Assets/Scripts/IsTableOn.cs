using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class IsTableOn : MonoBehaviour
{
    [SerializeField]
    public GameObject table;

    [SerializeField]
    public bool hasTable = false;

    [SerializeField]
    public float maxDistance = 5;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == table)
        {
            MeshRenderer m = gameObject.GetComponent<MeshRenderer>();
            m.enabled = true;
            hasTable = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        hasTable = false;
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == table)
        {
            MeshRenderer m = gameObject.GetComponent<MeshRenderer>();
            m.enabled = true;
            hasTable = true;
        }
        
        //Debug.Log(gameObject.name + " is being touched by " + table.name);
        /*
        if ((Vector3.Distance(other.transform.position, this.transform.position) < maxDistance) && other.name.Equals(table.name))
        {
            hasTable = true; // they are touching AND close
            Debug.Log(gameObject.name + " is being touched by " + table.name);
        }
        else
        {
            hasTable = false;
        }
        }
        
   
    private void OnTriggerExit(Collider other)
    {
        hasTable = false;
    }
    */
}
