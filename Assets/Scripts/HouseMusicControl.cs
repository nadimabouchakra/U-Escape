
using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class HouseMusicControl : MonoBehaviour
{


    public AudioMixerSnapshot outOfHouse;
    public AudioMixerSnapshot inHouse;
    public AudioClip[] stings;
    public AudioSource stingSource;
    public float bpm = 128;


    private float m_TransitionIn;
    private float m_TransitionOut;
    private float m_QuarterNote;

    // Use this for initialization
    void Start()
    {
        m_QuarterNote = 60 / bpm;
        m_TransitionIn = m_QuarterNote;
        m_TransitionOut = m_QuarterNote * 32;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HouseZone"))
        {
            inHouse.TransitionTo(m_TransitionIn);
            PlaySting();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HouseZone"))
        {
            outOfHouse.TransitionTo(m_TransitionOut);
        }
    }

    void PlaySting()
    {
        int randClip = Random.Range(0, stings.Length);
        stingSource.clip = stings[randClip];
        stingSource.Play();
    }


}
