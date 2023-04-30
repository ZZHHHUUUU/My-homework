using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_Collider : MonoBehaviour
{
    public GameObject doora;
    Animator DoorContainerAnim;
    void Start()
    {
        Animator DoorContainerAnim = doora.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            DoorContainerAnim.SetInteger("Control", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            DoorContainerAnim.SetInteger("Control", 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FPSController")
        {
            DoorContainerAnim.SetInteger("Control", 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "FPSController")
        {
            DoorContainerAnim.SetInteger("Control", 2);
        }
    }
}
