using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public int HP = 3;
    public Vector3 playerPosition = new Vector3(0, 0, 0);
    public AudioSource audio;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, 0.05f);
        transform.LookAt(playerPosition);
    }

    public void OnHit()
    {
        if (audio != null)
        {
            print("Sound!");
            audio.Play();
        }
        HP -= 1;
        if (HP == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
