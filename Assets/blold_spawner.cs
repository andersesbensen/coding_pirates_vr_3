using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blold_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            var tag = contact.otherCollider.tag;
            Debug.Log("Hit object " + tag);

            if ( tag == "grass" )
            {
                Debug.Log("Grass hit " + tag);
                var this_transform = GetComponent<Transform>();
                this_transform.position = new Vector3(0.0f, 1.0f, 0.5f) ;
            }
        }
     
    }
}
