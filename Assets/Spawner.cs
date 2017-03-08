using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public Object mailbox;
    public int chanceToSpawn = 20;
    public float counter = 0;
    public float longCounter = 0;
    public int counterLength;
	
    void Start()
    {
        counterLength = Random.Range(3, 6);
    }
	void Update () {
        longCounter += Time.deltaTime;
        counter += Time.deltaTime;
        if (counter > counterLength)
        {
            counter = 0;
            if (Random.Range(0, 100) <= chanceToSpawn && mailbox != null)
            {
                Instantiate(mailbox, transform.position, Quaternion.identity);
                print("Created!");
            }
        }

        if (longCounter > 30)
        {
            chanceToSpawn += 20;
        }
	}
}
