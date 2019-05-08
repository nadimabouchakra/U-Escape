
using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class HouseMusicControl : MonoBehaviour
{


    public AudioMixerSnapshot outOfHouse;
    public AudioMixerSnapshot inHouse;
    //public AudioClip[] stings;
    //public AudioSource stingSource;
    public float bpm = 128;


    private float m_TransitionIn;
    private float m_TransitionOut;
    private float m_QuarterNote;

    // Use this for initialization
    void Start()
    {
        m_QuarterNote = 60 / bpm;
        m_TransitionIn = m_QuarterNote * 8;
        m_TransitionOut = m_QuarterNote * 8;

    }

    void OnTriggerEnter(Collider other)
    {
       
        
        
        if (other.transform.root.name == "[VRTK_SDKManager]")
        {
            Debug.Log("JUST ENTERED: " + other.gameObject.transform.parent.gameObject.name);
            inHouse.TransitionTo(m_TransitionIn);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "[VRTK_SDKManager]")
        {
            outOfHouse.TransitionTo(m_TransitionOut);
        }
    }
    

}
