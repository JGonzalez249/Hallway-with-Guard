using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource m_MyAudioSource;
    private bool m_Play;

    private DebugLOS debugLOS;
    public AudioClip caught;
    private bool musicCheck;

    private void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_Play = true;
        musicCheck = false;
    }

    private void Update()
    {
        GameObject debugLOSObject = GameObject.FindWithTag("Enemy");
        if (debugLOSObject != null)
        {
            debugLOS = debugLOSObject.GetComponent<DebugLOS>();
        }
        if (debugLOSObject == null)
        {
            Debug.Log("hehe haha oops");
        }

        if (musicCheck == false && debugLOS.sight == 2)
        {
            m_MyAudioSource.Stop();
            m_MyAudioSource.clip = caught;
            m_MyAudioSource.Play();
            musicCheck = true;
        }

        //	if (m_Play == true)
        //        {
        //            m_MyAudioSource.Play();
        //        }
        //        if (m_Play == false)
        //        {
        //            m_MyAudioSource.Stop();
        //        }
    }
}