using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyContact : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag == "Boundary"){
            return;
        }

            Destroy(other.gameObject);
            Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
