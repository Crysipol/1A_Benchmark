using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject bomb;
    public GameObject explosionPrefab;
    public int BombHealth;

    //The bomb starts with 3 health
    void Start()
    {
        BombHealth = 3;
    }

    //When the user press H the bomb will lost one health an explode when it lose all of its health
    void Update()
    {
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
        //Pressing E will increase the health of the bomb
        if (Input.GetKeyDown(KeyCode.E))
        {
            BombHealth += 1;
        }
        //Space will play a sound
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<AudioSource>().Play();
        }
        //A message will appear when K key is pressed telling the user what they pressed
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("you've pressed K!");
        }
    }
}
