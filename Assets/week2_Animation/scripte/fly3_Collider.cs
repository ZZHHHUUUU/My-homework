using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly3_Collider : MonoBehaviour
{
    Transform fly3;
    // Start is called before the first frame update
    void Start()
    {
        fly3 = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            other.transform.SetParent(fly3);
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
