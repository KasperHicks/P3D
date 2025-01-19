using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public GameObject player;
    public PlayerHealth ph;
    public LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        ph = player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.CheckSphere(transform.position, 0.3f, ground))
        {
            //Debug.Log("Explode");
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("got hit");
            ph.TakeDamage();
            
        }

        
    }
}
