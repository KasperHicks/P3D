using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject swirl;
    public GameObject staticEffect;

    public LevelLoader ll;
    public GameObject level;
    // Start is called before the first frame update
    void Start()
    {
        //level = GameObject.Find("Level Loader");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            swirl.SetActive(false);
            staticEffect.SetActive(false);
            
            StartCoroutine(EndScreen());
        }


    }

    IEnumerator EndScreen()
    {
        //wait
        yield return new WaitForSeconds(3f);


        //load
        ll.LoadNextLevel();
    }
}
