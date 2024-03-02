using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject bomb;
    public GameObject explosionPrefab;
    public int BombHealth;

    // Start is called before the first frame update
    void Start()
    {
        BombHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // In part 2 I changed the key that reduce the bomb's health.
        if (Input.GetKeyDown(KeyCode.H))
        {
            BombHealth -= 1;
            if (BombHealth ==0)
            {
                GetComponent<AudioSource>().Play();
                Instantiate(explosionPrefab);
                Destroy(bomb);
                Debug.Log("Destroyed");
            }
           
        }
        // In part 2 I added a key that will increase the bomb's health.
        if (Input.GetKeyDown(KeyCode.E))
        {
            BombHealth += 1;
        }
        // In part 2 space key only plays the sound. 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<AudioSource>().Play();
        }
        //In part 3 a message pops when K is pressed.
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("you've pressed K!");
        }
    }
}
