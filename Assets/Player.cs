using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public bool isDead = false;
    public bool audioStarted = false;
    public AudioSource deathaudio;

    void Update()
    {
        if (audioStarted)
        {
            if(!deathaudio.isPlaying)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Mailbox" && !isDead)
        {
            deathaudio.Play();
            audioStarted = true;
            isDead = true;
        }
    }
}
