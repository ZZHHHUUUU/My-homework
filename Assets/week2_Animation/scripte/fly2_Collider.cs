using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly2_Collider : MonoBehaviour
{
    Transform fly2;
    // Start is called before the first frame update
    void Start()
    {
        fly2 = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            other.transform.SetParent(fly2);
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
