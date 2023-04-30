using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly4_Collider : MonoBehaviour
{
    Transform fly4;
    // Start is called before the first frame update
    void Start()
    {
        fly4 = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            other.transform.SetParent(fly4);
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
