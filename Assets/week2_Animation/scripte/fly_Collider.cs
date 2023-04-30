using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly_Collider : MonoBehaviour
{
    Transform fly1;
    // Start is called before the first frame update
    void Start()
    {
        fly1 = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            other.transform.SetParent(fly1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            other.transform.SetParent(null);
        }
    }
}

